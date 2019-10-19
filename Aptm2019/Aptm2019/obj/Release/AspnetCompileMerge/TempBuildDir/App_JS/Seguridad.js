$(document).ready(function () {
    $("#formLogin input").blur(function () {
        if ($(this).val() != "") {
            $(this).parent().parent().parent().removeClass("has-error");
            $(this).parent().parent().children("div").addClass("help-hidden");
        }
    });
});
function ValidarCamposLogin() {
    let cont = 0;
    $("#formLogin input").each(function () {
        let valor = $(this).val();
        if (valor == "") {
            cont++;
            $(this).parent().parent().parent().addClass("has-error");
            $(this).parent().parent().children("div").removeClass("help-hidden");
        }
    });
    return cont == 0;
}
//function MostrarError(mensaje) {
//    $("#divErrorLogin span.mensaje").html(mensaje);
//    $("#divErrorLogin").fadeIn("slow");
//}
//function OcultarError() {
//    $("#divErrorLogin").fadeOut("slow");
//    $("#divErrorLogin span.mensaje").html("");
//}
//function MostrarMensaje(mensaje, noCerrar) {
//    $("#box-success-message span.mensaje").html(mensaje);
//    $("#box-success-message").fadeIn("slow");
//    if (noCerrar) {
//        return;
//    }
//    setTimeout("OcultarMensaje()", 5000)
//}
function OcultarMensaje() {
    $("#box-success-message").fadeOut("slow");
    $("#box-success-message span.mensaje").html("");
}
function EnviarCorreoRecuperacion() {
    var cuenta = $("#Cuenta").val();

    if (cuenta != "") {
        $.ajax({
            url: '/WebSGESeguridad/Seguridad/EnviarCorreoRecuperacion',
            type: 'POST',
            data: { 'cuenta': cuenta },
            success: function (data) {
                if (data.Mensaje != "") {
                    MostrarMensaje(data.Mensaje);
                }
            },
            error: function (req, status, error) {
                flag = false;
                MostrarError("Ocurrió un error inesperado, vuelva a intentarlo en unos minutos o comuníquese con el área de sistemas.");
            }
        });
    } else {
        MostrarError("Debe ingresar la cuenta.");
    }
}
function ValidarCambioPassword(idusuario) {
    var flag = true;
    var expass = $("#passwordUsuario").val();
    if ((expass != undefined && expass != null && expass != "") || (idusuario != undefined && idusuario != null && idusuario != "" && idusuario != -1)) {
        var pass = $("#newpasswordUsuario").val();
        var repass = $("#renewpasswordUsuario").val();
        if (pass != undefined && pass != null && pass != "") {
            if (pass != repass) {
                flag = false;
                MostrarError("Las contraseñas ingresadas no coinciden.");
            } else {
                var expReg = /((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%!.-_]).{8,20})/;
                if (!pass.match(expReg)) {
                    flag = false;
                    MostrarError("El password debe contener al menos 8 caracteres incluyendo 1 mayúscula, 1 minúscula, 1 número y 1 caracter especial.");
                }
            }
        } else {
            flag = false;
            MostrarError("Debe ingresar la contraseña nueva.");
        }
    } else {
        flag = false;
        MostrarError("Debe ingresar la contraseña actual.");
    }
    return flag;
}
let _urlSeguridad = document.currentScript.getAttribute('urlSeguridad');
if (document.currentScript.getAttribute('loginModal') === 'true') {
    $.ajaxSetup({
        beforeSend: function (xhr) {
            let _xhr = new XMLHttpRequest();
            _xhr.open('POST', _urlSeguridad + 'ValidarSesion', false);
            _xhr.send();
            if (_xhr.status === 200) {
                if (!JSON.parse(_xhr.responseText).LAutorizado) {
                    xhr.abort();
                    window.location.reload();
                }
            }
        }
    });
} else {
    $().ready(() => {
        $("#btnLogin").click(() => {
            if (!ValidarCamposLogin())
                return false;
            $.ajax({
                type: "POST",
                url: _urlSeguridad + 'Procesar',
                data: { CLoginUserName: $("#loginUsername").val(), CLoginPassword: $("#passwordUsuario").val() },
                success: (r) => {
                    if (r.Result == "OK") {
                        if (r.Login) {
                            window.location.href = _urlSeguridad + "../" + r.Url;
                        } else {
                            Swal.fire("Acceso no autorizado", r.Message, 'warning');
                        }
                    } else {
                        Swal.fire("Error!", "Ocurrió un error inesperado, vuelva a intentarlo en unos minutos o comuníquese con el área de sistemas.", 'error');
                        console.log(r.Message);
                    }
                },
                beforeSend: () => showLoading('Iniciando sesión...'),
                complete: () => hideLoading()
            });
        });
        $("#passwordUsuario").keydown((evt) => {
            if (evt.keyCode == 13)
                $("#btnLogin").click();
        });
        $("#formLogin").modal({ backdrop: 'static', keyboard: false });
    });
}

