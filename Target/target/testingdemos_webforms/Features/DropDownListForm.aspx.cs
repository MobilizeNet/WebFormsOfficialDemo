using System;
using System.Collections.Generic;
using System.Linq;
using TestingDemos_WebForms.Classes;
using Mobilize.WebMap.Common.Attributes;

namespace TestingDemos_WebForms
{

   [Observable]
   public partial class DropDownListForm : Mobilize.Web.UI.Controls.Page
   {
       protected void Page_Load(object sender, EventArgs e)
       {
           List<ClassItemsL> l = new List<ClassItemsL>();
           l.Add(new ClassItemsL { Id = 1, Description = "Item 1" });
           l.Add(new ClassItemsL { Id = 2, Description = "Item 2" });
           l.Add(new ClassItemsL { Id = 3, Description = "Item 3" });
           this.Session["dataItem"] = l;
           UpdatedDropDown(l);
       }

       protected void Button1_Click(object sender, EventArgs e)
       {
           var flag = (this.DropDownList1.Visible) ? false : true;
           this.DropDownList1.Visible = flag;
       }

       protected void Button2_Click(object sender, EventArgs e)
       {
           var dataItems = this.Session["dataItem"] as List<ClassItemsL>;
           dataItems.Add(new ClassItemsL { Id = 4, Description = "Item 4" });
           UpdatedDropDown(dataItems);
        }

       protected void Button3_Click(object sender, EventArgs e)
       {
           var dataItems = this.Session["dataItem"] as List<ClassItemsL>;
           int index = this.DropDownList1.Items.Count;
           if (index - 1 >= 0)
           {
               dataItems.RemoveAt(index - 1);
               UpdatedDropDown(dataItems);
            }
       }

       protected void Button4_Click(object sender, EventArgs e)
       {
           int index = this.DropDownList1.Items.Count;
           var textButton = (this.Button4.Text == "TotalItems") ? index.ToString() : "TotalItems";
           this.Button4.Text = textButton;
       }

       protected void Button5_Click(object sender, EventArgs e)
       {
           int index = this.DropDownList1.Items.Count;
           if (index - 1 >= 0)
           {
               this.DropDownList1.SelectedIndex = index - 1;
           }
       }

       protected void Button6_Click(object sender, EventArgs e)
       {
           var flag = (this.DropDownList1.Enabled) ? false : true;
           this.DropDownList1.Enabled = flag;
       }

       protected void Button7_Click(object sender, EventArgs e)
       {
           var dataItems = this.Session["dataItem"] as List<ClassItemsL>;
           dataItems.Clear();
           dataItems.Add(new ClassItemsL { Id = 1, Description = "Item 1" });
           dataItems.Add(new ClassItemsL { Id = 2, Description = "Item 2" });
           dataItems.Add(new ClassItemsL { Id = 3, Description = "Item 3" });
           UpdatedDropDown(dataItems);
        }

        private void UpdatedDropDown(List<ClassItemsL> l)
        {
            this.DropDownList1.DataValueField = "Id";
            this.DropDownList1.DataTextField = "Description";
            this.DropDownList1.DataSource = l;
            this.DropDownList1.DataBind();
        }

   }
}