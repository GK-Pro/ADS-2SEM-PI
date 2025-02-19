﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI
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
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "PesquisaGeral",
                routeTemplate: "api/{controller}/pesquisa/{pesquisa}",
                defaults: new { pesquisa = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "PesquisaAutor",
                routeTemplate: "api/{controller}/autor/{autor}",
                defaults: new { autor = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "PesquisaTitulo",
                routeTemplate: "api/{controller}/titulo/{titulo}",
                defaults: new { titulo = RouteParameter.Optional }
            );
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.JsonFormatter.Indent = true;

        }
    }
}
