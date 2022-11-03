using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.FriendlyUrls.Resolvers;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TestingDemos_WebForms
{

   [Observable]
   public partial class ViewSwitcher : Mobilize.Web.UI.Controls.UserControl
   {

      [Intercepted]
      protected string CurrentView { get; private set; }

      [Intercepted]

      protected string AlternateView { get; private set; }

      [Intercepted]

      protected string SwitchUrl { get; private set; }

      protected void Page_Load(object sender, EventArgs e)
      {
          // Determine current view
          var isMobile = Stub._Microsoft.AspNet.FriendlyUrls.Resolvers.WebFormsFriendlyUrlResolver.IsMobileView(new Stub._System.Web.HttpContextWrapper(this.Properties().Context));
         CurrentView = isMobile ? "Mobile" : "Desktop";

         // Determine alternate view
         AlternateView = isMobile ? "Desktop" : "Mobile";

         // Create switch URL from the route, e.g. ~/__FriendlyUrls_SwitchView/Mobile?ReturnUrl=/Page
         var switchViewRouteName = "AspNet.FriendlyUrls.SwitchView";
         var switchViewRoute = Stub._System.Web.Routing.RouteTable.Routes[switchViewRouteName];
         if (switchViewRoute == null)
         {
             // Friendly URLs is not enabled or the name of the switch view route is out of sync
             this.Visible = false;
             return;
         }
         var url = this. GetRouteUrl(switchViewRouteName, new { view = AlternateView, __FriendlyUrls_SwitchViews = true });
         url += "?ReturnUrl=" + Stub._System.Web.HttpUtility.UrlEncode(Request.RawUrl);
         SwitchUrl = url;
     }

   }
}