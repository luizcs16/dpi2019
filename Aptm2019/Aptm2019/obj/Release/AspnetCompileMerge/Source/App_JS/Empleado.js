let mode = document.currentScript.getAttribute('Mode');
$(document).ready(function () {
    if (mode === 'Index') {
        $('#EmpleadoTableContainer').jtable({
            title: 'Lista de Empleados',
            paging: true,
            sorting: true,
            defaultSorting: 'Name ASC',
            actions: {
                listAction: '/Empleado/EmpleadoListByFiter'
                //deleteAction: '/Demo/DeleteStudent',
                //updateAction: '/Demo/UpdateStudent',
                //createAction: '/Demo/CreateStudent'
            },
            fields: {

                MEMP_nId: {
                    key: true,
                    create: false,
                    edit: false,
                    list: false
                },
                MEMP_cNombre: {
                    title: 'Nombre',
                    width: '23%'
                },
                MEMP_cApePaterno: {},
                MEMP_cApeMaterno: {},
                MEMP_nTipoDoc: {
                    //options: '/Demo/GetCityOptions'
                },
                MEMP_nDocumento: {},
                MEMP_cDireccion: {},
                MEMP_cTelefono: {},
                MEMP_lActivo: {
                    type: 'checkbox',
                    values: { 'false': 'Passive', 'true': 'Active' },
                },
                MEMP_nUsrReg: {},
                MEMP_dFechReg: {
                    title: 'Record date',
                    width: '15%',
                    type: 'date',
                    displayFormat: 'dd.mm.yy',
                    create: false,
                    edit: false,
                    sorting: false //This column is not sortable!
                },
                MEMP_nUsrMod: {},
                MEMP_dFechMod: {}
            }
        });
    }
    if (mode === 'Create' || mode === 'Update') {
        $("#MEMP_nTipoDoc").chosen({ no_results_text: "No existen más tipos para filtrar." });
    }

    ////Re-load records when user click 'load records' button.
    //$('#LoadRecordsButton').click(function (e) {
    //    e.preventDefault();
    //    $('#StudentTableContainer').jtable('load', {
    //        name: $('#name').val(),
    //        cityId: $('#cityId').val()
    //    });
    //});

    ////Load all records when page is first shown
    //$('#LoadRecordsButton').click();
});