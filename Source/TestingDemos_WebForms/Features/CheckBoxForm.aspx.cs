using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestingDemos_WebForms
{
    public partial class CheckBoxForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var checkbox1 = this.CheckBox1;
            if (checkbox1.Visible)
            {
                checkbox1.Visible = false;
            }
            else
            {
                checkbox1.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var checkbox1 = this.CheckBox1;
            if (checkbox1.Checked)
            {
                checkbox1.Checked = false;
            }
            else
            {
                checkbox1.Checked = true;
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            var button3 = this.Button3;
            if (button3.Text.Equals("Unchecked"))
            {
                button3.Text = "Checked";
            }
            else
            {
                button3.Text = "Unchecked";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var checkbox1 = this.CheckBox1;
            if (checkbox1.Enabled)
            {
                checkbox1.Enabled = false;
            }
            else
            {
                checkbox1.Enabled = true;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            var checkbox1 = this.CheckBox1;
            if (checkbox1.Visible)
            {
                checkbox1.Visible = false;
            }
            else
            {
                checkbox1.Visible = true;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            var checkbox1 = this.CheckBox1;
            if (checkbox1.Text.Equals("Checkbox1"))
            {
                checkbox1.Text = "TextChanged";
            }
            else
            {
                checkbox1.Text = "Checkbox1";
            }
        }
    }
}