using DeLoachAero.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;

namespace ApiProject2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes

            var constraintResolver = new DefaultInlineConstraintResolver();
            constraintResolver.ConstraintMap.Add("enum", typeof(EnumerationConstraint));
            config.MapHttpAttributeRoutes(constraintResolver);

            //config.MapHttpAttributeRoutes();


            // config.Routes.MapHttpRoute(
            //    name: "ProductsApi",
            //    routeTemplate: "api/prod/{id}",
            //    defaults: new { controller="Products", id = RouteParameter.Optional }
            //);

            // config.Routes.MapHttpRoute(
            //     name: "DefaultApi",
            //     routeTemplate: "api/{controller}/{id}",
            //     defaults: new { id = RouteParameter.Optional }
            // );
        }
    }
}
