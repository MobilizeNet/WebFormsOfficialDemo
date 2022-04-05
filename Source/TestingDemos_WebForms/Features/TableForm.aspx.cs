using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestingDemos_WebForms
{
    public partial class TableForm : System.Web.UI.Page
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