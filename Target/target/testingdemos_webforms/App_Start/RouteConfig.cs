using System;
using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TestingDemos_WebForms
{

   [Observable]
   public static class RouteConfig
   {
       public static void RegisterRoutes(Stub._System.Web.Routing.RouteCollection routes)
      {
          var settings = new Stub._Microsoft.AspNet.FriendlyUrls.FriendlyUrlSettings();
          settings.AutoRedirectMode = Stub._Microsoft.AspNet.FriendlyUrls.RedirectMode.Permanent;
          routes.EnableFriendlyUrls(settings);
      }

   }
}