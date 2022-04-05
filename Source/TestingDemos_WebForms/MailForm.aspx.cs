using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestingDemos_WebForms
{
    public partial class MailForm : System.Web.UI.Page
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