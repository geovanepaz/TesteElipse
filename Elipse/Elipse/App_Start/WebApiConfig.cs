using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace Elipse
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();
 
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "Elipse/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "previsao",
                routeTemplate: "{cidade}/{controller}",
                defaults: new { cidade = RouteParameter.Optional }
            );
        }
    }
}
