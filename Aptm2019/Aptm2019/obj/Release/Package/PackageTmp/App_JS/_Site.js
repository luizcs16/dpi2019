
function showLoading(mensaje) {
    $("#loadingModal").css({ 'display': 'block' });
    $("#loadingModal").find('#loadingMessage').html(mensaje || 'Cargando servicios...');

}
function hideLoading() {
    $("#loadingModal").css({ 'display': 'none' });
    $("#loadingModal").find('#loadingMessage').html('');
}

$(document).ready(function () {
    $('#dismiss, .overlay').on('click', function () {
        // hide sidebar
        $('#sidebar').removeClass('active');
        // hide overlay
        $('.overlay').removeClass('active');
    });

    $('#sidebarCollapse').hover(function () {
        // open sidebar
        $('#sidebar').addClass('active');
        // fade in the overlay
        $('.overlay').addClass('active');
        $('.collapse.in').toggleClass('in');
        $('a[aria-expanded=true]').attr('aria-expanded', 'false');
    }, null);
});


//
function ValidarFormulario() {
    OcultarError();
    var flag = true;
    $(".error-input").each(function () {
        $(this).addClass("warning-input");
        $(this).removeClass("error-input");
        $(this).parent().next().hide();
    });
    $(".warning-input").each(function () {
        if ($(this).val() == "") {
            $(this).removeClass("warning-input");
            $(this).addClass("error-input");
            $(this).parent().next().html("Campo requerido.")
            $(this).parent().next().show();
            flag = false;
        }
    });
    if (flag) {
        var pass = $(".password-input").val();
        var repass = $(".repassword-input").val();
        if (pass != undefined && pass != null && pass != "") {
            if (pass != repass) {
                flag = false;
                $(".password-input").removeClass("warning-input");
                $(".password-input").addClass("error-input");
                $(".repassword-input").removeClass("warning-input");
                $(".repassword-input").addClass("error-input");
                MostrarError("Las contraseñas ingresadas no coinciden");
            } else {
                var expReg = /((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%!.]).{8,20})/;
                if (!pass.match(expReg)) {
                    flag = false;
                    $(".password-input").removeClass("warning-input");
                    $(".password-input").addClass("error-input");
                    $(".repassword-input").removeClass("warning-input");
                    $(".repassword-input").addClass("error-input");
                    MostrarError("El password debe contener al menos 8 caracteres incluyendo 1 mayúscula, 1 minúscula, 1 número y 1 caracter especial.");
                }
            }
        }
    }
    if (flag) {
        var cuenta = $(".account-input").val();
        if (cuenta != undefined) {
            $.ajax({
                url: 'ValidarCuenta',
                type: 'POST',
                async: false,
                data: { 'cuentaUsuario': cuenta },
                success: function (data) {
                    if (data.Mensaje != "") {
                        flag = false;
                        MostrarError(data.Mensaje);
                    }
                },
                error: function (req, status, error) {
                    flag = false;
                    MostrarError("Ocurrió un error inesperado, vuelva a intentarlo en unos minutos o comuníquese con el área de sistemas.");
                }
            });
        }
    }
    return flag;
}
function OcultarError() {
    $("#box-error-message").fadeOut("slow");
    $("#box-error-message span.mensaje").html("");
}