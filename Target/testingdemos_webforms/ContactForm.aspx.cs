using System;
using System.Collections.Generic;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TestingDemos_WebForms
{

   [Observable]
   public partial class ContactForm : Mobilize.Web.UI.Controls.Page
   {
       protected void Page_Load(object sender, EventArgs e)
       {
           message.Text = "";
       }

       protected void enviar_Click(object sender, EventArgs e)
       {
           if ( Page.Properties().IsValid)
         {
             message.Text = "Tu mensaje ha sido enviado.";
         }
     }

   }
}