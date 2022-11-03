using System;
using System.Collections.Generic;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TestingDemos_WebForms
{

   [Observable]
   public class Global : Stub._System.Web.HttpApplication
   {
       void Application_Start(object sender, EventArgs e)
       {
           // Code that runs on application startup
           RouteConfig.RegisterRoutes(Stub._System.Web.Routing.RouteTable.Routes);
           BundleConfig.RegisterBundles(Stub._System.Web.Optimization.BundleTable.Bundles);
       }

   }
}