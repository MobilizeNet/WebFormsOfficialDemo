using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Mobilize.WebMap.Common.Attributes;

namespace TestingDemos_WebForms
{

   [Observable]
   public partial class TableForm : Mobilize.Web.UI.Controls.Page
   {
       protected void Page_Load(object sender, EventArgs e)
       {

       }

       protected void btnSubmit_Click(object sender, EventArgs e)
       {
           var option = (this.successfulMessage.Visible) ? false : true;
           this.successfulMessage.Visible = option;
       }

   }
}