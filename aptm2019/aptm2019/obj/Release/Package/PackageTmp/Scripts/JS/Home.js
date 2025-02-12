﻿var points = [],
    msg_el = document.getElementById('msg'),
    url_osrm_nearest = '//router.project-osrm.org/nearest/v1/driving/',
    url_osrm_route = '//router.project-osrm.org/route/v1/driving/',
    icon_url = '/Images/marker.png',
    vectorSource = new ol.source.Vector(),
    vectorLayer = new ol.layer.Vector({
        source: vectorSource
    }),
    styles = {
        route: new ol.style.Style({
            stroke: new ol.style.Stroke({
                width: 3, color: [0, 0, 255, 0.5]
            })
        }),
        icon: new ol.style.Style({
            image: new ol.style.Icon({
                anchor: [0.5, 1],
                src: icon_url
            })
        })
    };

console.clear();

var map = new ol.Map({
    target: 'map',
    layers: [
        new ol.layer.Tile({
            source: new ol.source.OSM()
        }),
        vectorLayer
    ],
    view: new ol.View({
        center: ol.proj.fromLonLat([-77.0030995, -12.0312882]),
        zoom: 14
    })
});

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
            utils.createRoute(json.routes[0].geometry);
        });
    });
});

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
    createRoute: function (polyline) {
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
        feature.setStyle(styles.route);
        vectorSource.addFeature(feature);
    },
    to4326: function (coord) {
        return ol.proj.transform([
            parseFloat(coord[0]), parseFloat(coord[1])
        ], 'EPSG:3857', 'EPSG:4326');
    }
};