let mode = document.currentScript.getAttribute('mode');

var points = [],
    msg_el = document.getElementById('msg'),
    url_osrm_nearest = '//router.project-osrm.org/nearest/v1/driving/',
    url_osrm_route = '//router.project-osrm.org/route/v1/driving/',
    icon_url = '/Images/marker.png',
    vectorSource = new ol.source.Vector(),
    vectorLayer = new ol.layer.Vector({
        source: vectorSource
    }),
    vectorSource2 = new ol.source.Vector(),
    vectorLayer2 = new ol.layer.Vector({
        source: vectorSource2
    }),
    styles = {
        route: new ol.style.Style({
            stroke: new ol.style.Stroke({
                width: 3, color: [0, 0, 255, 0.5]
            })
        }),
        route2: new ol.style.Style({
            stroke: new ol.style.Stroke({
                width: 3, color: [255, 0, 7, 0.5]
            })
        }),
        icon: new ol.style.Style({
            image: new ol.style.Icon({
                anchor: [0.5, 1],
                src: icon_url
            })
        })
    };


var map = new ol.Map({
    target: 'map',
    layers: [
        new ol.layer.Tile({
            source: new ol.source.OSM()
        }),
        vectorLayer,
        vectorLayer2
    ],
    view: new ol.View({
        center: ol.proj.fromLonLat([-77.0030995, -12.0312882]),
        zoom: 14
    })
});

if (mode === 'Test') {
    map.on('click', function (evt) {
        utils.getNearest(evt.coordinate).then(function (coord_street) {
            var last_point = points[points.length - 1];
            var points_length = points.push(coord_street);

            utils.createFeature(coord_street);

            if (points_length < 2) {
                msg_el.innerHTML = 'Click para agregar otro punto.';
                return;
            }

            //get the route
            var point1 = last_point.join();
            var point2 = coord_street.join();

            fetch(url_osrm_route + point1 + ';' + point2).then(function (r) {
                return r.json();
            }).then(function (json) {
                if (json.code !== 'Ok') {
                    msg_el.innerHTML = 'Ruta no encontrada.';
                    return;
                }
                msg_el.innerHTML = 'Se agregó una ruta.';
                //points.length = 0;
                utils.createRoute(vectorSource,json.routes[0].geometry, styles.route);
            });
        });
    });
} else if (mode === 'TestPlanning') {
    map.on('click', function (evt) {
        utils.getNearest(evt.coordinate).then(function (coord_street) {

            var last_point = points[points.length - 1];
            var points_length = points.push(coord_street);

            utils.createFeature(coord_street);

            if (points_length < 2) {
                msg_el.innerHTML = 'Click para agregar otro punto.';
                return;
            }

                //get the route
                var point1 = last_point.join();
                var point2 = coord_street.join();

                fetch(url_osrm_route + point1 + ';' + point2).then(function (r) {
                    return r.json();
                }).then(function (json) {
                    if (json.code !== 'Ok') {
                        msg_el.innerHTML = 'Ruta no encontrada.';
                        return;
                    }
                    msg_el.innerHTML = 'Se agregó una ruta.';
                    //points.length = 0;
                    utils.createRoute(vectorSource,json.routes[0].geometry, styles.route);
                });
            

            if (points_length > 2) {

                vectorSource1.clear();
                vectorSource2.clear();
                let nodos = [];
                points.forEach(function (p) {
                    nodos.push({
                        cGeometry: '',
                        nCosto: 0 * 1,
                        nLat: p[1] * 1,
                        nLong: p[0] * 1
                    });
                });

                $.ajax({
                    url: 'GetRutasPlan',
                    type: 'POST',
                    data: { 'nodos': JSON.stringify(nodos) },
                    success: function (data) {
                        data.forEach(function (p) {
                            utils.createRoute(vectorSource2,p.cGeometry, styles.route2);
                        });
                    },
                    error: function (req, status, error) {
                        alert("Ocurrió un error inesperado, intente nuevamente en unos minutos o comuníquese con el área de sistemas.");
                    }
                });

            }
            

        });
    });
}



var utils = {
    getNearest: function (coord) {
        var coord4326 = utils.to4326(coord);
        return new Promise(function (resolve, reject) {
            //make sure the coord is on street
            fetch(url_osrm_nearest + coord4326.join()).then(function (response) {
                // Convert to JSON
                return response.json();
            }).then(function (json) {
                if (json.code === 'Ok') resolve(json.waypoints[0].location);
                else reject();
            });
        });
    },
    createFeature: function (coord) {
        var feature = new ol.Feature({
            type: 'place',
            geometry: new ol.geom.Point(ol.proj.fromLonLat(coord))
        });
        feature.setStyle(styles.icon);
        vectorSource.addFeature(feature);
    },
    createRoute: function (vectorSource,polyline,styles) {
        // route is ol.geom.LineString
        var route = new ol.format.Polyline({
            factor: 1e5
        }).readGeometry(polyline, {
            dataProjection: 'EPSG:4326',
            featureProjection: 'EPSG:3857'
        });
        var feature = new ol.Feature({
            type: 'route',
            geometry: route
        });
        feature.setStyle(styles);
        vectorSource.addFeature(feature);
    },
    to4326: function (coord) {
        return ol.proj.transform([
            parseFloat(coord[0]), parseFloat(coord[1])
        ], 'EPSG:3857', 'EPSG:4326');
    }
};



$(document).ready(function () {

    $('#accordionAPTM').on('show.bs.collapse', function () {;
        $(this).find('.collapse.in').collapse('hide');
    })
    $("#cboMReparto").chosen({ no_results_text: "No existen repartos para filtrar." });
    if (mode === 'Index') {
        $("#cboMReparto").change(function () {
            let idReparto = $("#cboMReparto").val() * 1;
            $.ajax({
                url: 'GetDetallesReparto',
                type: 'POST',
                data: { 'idReparto': idReparto },
                success: function (data) {
                    $("#txtPlaca").val(data.cPLaca);
                    $("#txtConductor").val(data.cEMP);
                    $("#txtHorario").val(data.cHorario);
                    let inner = '';
                    data.oCarga.forEach(function (p) {
                        points.push([p.nLong, p.nLat]);

                        utils.createFeature([p.nLong, p.nLat]);

                        inner += '<div class="card-header">' + p.cCliente + '</div >' + p.cDireccion;

                    });

                    $("#txtDetalleReparto").html(inner);
                },
                error: function (req, status, error) {
                    alert("Ocurrió un error inesperado, intente nuevamente en unos minutos o comuníquese con el área de sistemas.");
                }
            });
        });
        $("#btnGenerarRutas").click(function () {

            points.forEach(function (p, r, a) {

                if (r < points.length - 1) {
                    let url = url_osrm_route + a[r] + ';' + a[r + 1];
                    console.log(url);
                    fetch(url).then(function (r) {
                        return r.json();
                    }).then(function (json) {
                        utils.createRoute(vectorSource,json.routes[0].geometry, styles.route);
                    });
                }

            });

        });
    }
    
});


