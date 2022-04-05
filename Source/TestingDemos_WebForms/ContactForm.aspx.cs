using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestingDemos_WebForms
{
    public partial class ContactForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            message.Text = "";
        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                message.Text = "Tu mensaje ha sido enviado.";
            }
        }
    }
}