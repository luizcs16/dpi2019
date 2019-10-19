
using aptm2019.Models.Seguridad;
using Aptm2019.BusinessLogicLayer;
using Aptm2019.EntityLayer;
using Aptm2019.Security;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Net;
using System.Net.Security;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;

namespace Aptm2019.Controllers
{
    public class SeguridadController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login() => View();
        [AcceptVerbs(HttpVerbs.Get|HttpVerbs.Post)]
        public ActionResult Logout()
        {
            if (Session["UsuarioObj"] != null)
                Session.RemoveAll();
            Session.Clear();
            Session.Abandon();
            return Redirect("~/Seguridad/Login");
        }

        [HttpPost]
        public JsonResult ValidarSesion()
        {
            bool lAutorizado = false;
            if (Session["LAutorizado"] != null)
                bool.TryParse(Session["LAutorizado"] as string, out lAutorizado);
            return Json(new { LAutorizado = lAutorizado });
        }
        private static bool LoginAutenticado(LoginModel oLogin, Controller controller)
        {
            bool lAutenticado;
            if (ConfigurationManager.AppSettings[""] == "on")
            {
                ENT_MUsuario usr = new BLL_MUsuario().SelectByLogin(oLogin.CLoginUserName, Encryptor.EncryptTripleDES(oLogin.CLoginPassword, "dpi2019"));

                lAutenticado = usr != null;
            }
            else
            {
                lAutenticado = true;
            }
            if (lAutenticado)
            {
                controller.Session.Add("UsuarioObj", oLogin);
                controller.Session.Add("LAutorizado", "true");
            }
            return lAutenticado;
        }

        [HttpPost]
        public JsonResult Procesar(LoginModel oLogin)
        {
            try
            {
                if (LoginAutenticado(oLogin, this))
                {
                    //Genera url de redireccionamiento
                    string urlRedirect = null;
                    //Obtener datos del filtro en atributo ValidarSeguridad
                    if (Session["redirectValues"] != null && Session["redirectUrl"] != null)
                    {
                        RouteValueDictionary redirect = Session["redirectValues"] as RouteValueDictionary;
                        urlRedirect = Session["redirectUrl"] as string;

                        foreach (Match match in Regex.Matches(urlRedirect, @"\{([^\}]*)\}"))
                        {
                            string val = match.Value.Replace("{", "").Replace("}", "");
                            urlRedirect = urlRedirect.Replace(match.Value, redirect[val] != null ? redirect[val] as string : string.Empty);
                        }
                        if (urlRedirect[urlRedirect.Length - 1] == '/')
                            urlRedirect = urlRedirect.Remove(urlRedirect.Length - 1);

                        Session.Remove("redirectValues");
                        Session.Remove("redirectUrl");
                    }
                    else
                    {
                        urlRedirect = "Home/Index";
                    }


                    return Json(new { Result = "OK", Message = "Acceso concedido", Login = true, Url = urlRedirect });
                }
                else
                {
                    return Json(new { Result = "OK", Message = "Usuario y/o contraseña incorrecta." });
                }

            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", ex.Message });
            }
        }
        //    public static bool SesionCookieValido(Controller controller)
        //    {
        //        bool lAutenticado = false;
        //        if (controller.Request.Cookies[ConfigurationManager.AppSettings["CookieKeyToken1"]] != null)
        //        {
        //            if (controller.Request.Cookies[ConfigurationManager.AppSettings["CookieKeyToken2"]] != null)
        //            {
        //                string keyValue1 = controller.Request.Cookies[ConfigurationManager.AppSettings["CookieKeyToken1"]].Value;
        //                string keyValue2 = Encryptor.DecryptTripleDES(controller.Request.Cookies[ConfigurationManager.AppSettings["CookieKeyToken2"]].Value, keyValue1);
        //                lAutenticado = LoginAutenticado(JsonConvert.DeserializeObject<LoginModel>(keyValue2), controller);
        //            }
        //        }
        //        return lAutenticado;
        //    }
        //    private static LoginModel GetLogin_AplicacionesTerceros()
        //    {
        //        return new LoginModel() {
        //            CLoginUserName = ConfigurationManager.AppSettings["CookieKeyAppUser"],
        //            CLoginPassword = ConfigurationManager.AppSettings["CookieKeyAppPw"]
        //        };
        //    }

        //    private static void GenerarCookieSesion(LoginModel oLogin, HttpCookieCollection cookieCollection)
        //    {
        //        DateTime dFechaExpiracion = DateTime.Now;
        //        //Establecer limite de inactividad para la sesion del cookie
        //        int tiempoDuracionCookie = 0;
        //        if (Int32.TryParse(ConfigurationManager.AppSettings["TiempoDuracionCookie"], out tiempoDuracionCookie))
        //            dFechaExpiracion = dFechaExpiracion.AddDays(tiempoDuracionCookie);

        //        string keyValue1 = Encryptor.EncryptTripleDES(dFechaExpiracion.ToString("yyyy=ss-MM*mm_dd%HH"), ConfigurationManager.AppSettings["CookieKeyDecrypt"]);
        //        string keyValue2 = Encryptor.EncryptTripleDES(JsonConvert.SerializeObject(oLogin), keyValue1);

        //        cookieCollection.Add(new System.Web.HttpCookie(ConfigurationManager.AppSettings["CookieKeyToken1"]) { Value = keyValue1, Expires = dFechaExpiracion });
        //        cookieCollection.Add(new System.Web.HttpCookie(ConfigurationManager.AppSettings["CookieKeyToken2"]) { Value = keyValue2, Expires = dFechaExpiracion });
        //    }

        //    [AcceptVerbs(HttpVerbs.Get|HttpVerbs.Post)]
        //    public JsonResult GenerarCookie(string _Token)
        //    {
        //        if (!string.IsNullOrEmpty(_Token))
        //        {
        //            if (Request.Cookies["_Token"] != null)
        //            {
        //                string expiracionSolicitud = Encryptor.DecryptTripleDES(_Token, Request.Cookies["_Token"].Value);
        //                DateTime dFechaExp = Convert.ToDateTime(expiracionSolicitud);
        //                if(DateTime.Now < dFechaExp)
        //                {
        //                    GenerarCookieSesion(GetLogin_AplicacionesTerceros(), Response.Cookies);
        //                    //GenerarCookieSesion(GetLogin_AplicacionesTerceros(), Request.Cookies);
        //                    return Json(new { Result = "OK", Message = "Generacion deCookie Satisfactoria" });
        //                }
        //            }
        //        }
        //        JsonResult res = Json(new { Result = "Fail" });
        //        res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
        //        return res;
        //    }


    }
}