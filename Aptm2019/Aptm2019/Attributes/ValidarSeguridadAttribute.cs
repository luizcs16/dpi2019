
using Aptm2019.Controllers;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aptm2019.Attributes
{
    public class ValidarSeguridadAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(filterContext.ActionDescriptor.ControllerDescriptor.ControllerType != typeof(SeguridadController))
            {
                if (filterContext.HttpContext.Session["UsuarioObj"] == null)
                {
                    if (filterContext.HttpContext.Request.HttpMethod == "GET")
                    {
                        filterContext.HttpContext.Session.Add("redirectValues", filterContext.RouteData.Values);
                        filterContext.HttpContext.Session.Add("redirectUrl", (filterContext.RouteData.Route as Route).Url);
                        filterContext.HttpContext.Response.Redirect("~/Seguridad/Login", true);
                    }
                    else
                    {
                        filterContext.Result = new JsonResult
                        {
                            Data = new { Result = "¡ACCESO NO AUTORIZADO!", Message = "Fallo en la autenticación de usuario. \nInicie sesión nuevamente o comuníquese con el área de sistemas." }
                        };
                    }
                    
                }
            }
        }
    }
}