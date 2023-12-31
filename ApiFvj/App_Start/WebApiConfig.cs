﻿using ApiFvj.Fiilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ApiFvj
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Filters.Add(new ValidateModelState());

            // Web API configuration and services

            // Web API routes
            // config.EnableCors();
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
                name: "SwaggerApi",
                routeTemplate: "api/token"
            );

            config.Routes.MapHttpRoute(
                name: "TokenAdmin",
                routeTemplate: "api/tokenadmin"
            );


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            
        }
    }
}
