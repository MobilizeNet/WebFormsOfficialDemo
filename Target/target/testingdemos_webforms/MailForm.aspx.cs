using System;
using System.Collections.Generic;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace TestingDemos_WebForms
{

   [Observable]
   public partial class MailForm : Mobilize.Web.UI.Controls.Page
   {
       protected void Page_Load(object sender, EventArgs e)
       {

       }

       protected void Button1_Click(object sender, EventArgs e)
       {
           var name = this.TextBox1.Text;
           var mail = this.TextBox2.Text;
           var message = this.TextBox3.Text;

           this.Label3.Visible = true;
           this.Label3.Text = "Your Message has been send to: " + mail;
       }

   }
}