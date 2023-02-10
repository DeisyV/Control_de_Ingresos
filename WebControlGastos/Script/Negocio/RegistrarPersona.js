const _Nombre;
const _Numero;



$('#btnBuscar').on('click', function (e) {
    debugger;
    e.preventDefault();

    _Nombre = $('#txtNombre').val();
    _Numero = $('#txtnumero').val();
    /*TablaPersonas.ajax.reload();*/
});