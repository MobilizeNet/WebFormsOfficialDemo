using System;
using System.Collections.Generic;
using System.Linq;
using TestingDemos_WebForms.Classes;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TestingDemos_WebForms
{

   [Observable]
   public partial class OtherComponents : Mobilize.Web.UI.Controls.Page
   {

      [Intercepted]
      public object CheckBox1 { get; private set; }

      protected void Page_Load(object sender, EventArgs e)
      {
          if (!IsPostBack)
          {
              var products = new List<Products>();

              Products product1 = new Products();
              product1.IdProduct = "BTRF" + DateTime.Now.Ticks.ToString().Substring(0, 10);
              product1.Name = "Samsung TV 4k 32";
              product1.Details = "Last generation";
              product1.CategoryIndex = 1;
              product1.Category = "Electronic devices";
              product1.IsNew = true;
              product1.Odetails = "Black friday";
              products.Add(product1);
              this.Session["dataProducts"] = products;
              this.GridView1.DataSource = products;
              this.GridView1.DataBind();
          }
      }

      protected void addButton_Click(object sender, EventArgs e)
      {
          Products newProduct = new Products();
          var products = this.Session["dataProducts"] as List<Products>;
          newProduct.IdProduct = "BTRF" + DateTime.Now.Ticks.ToString().Substring(0, 10);
          newProduct.Name = this.ProductName.Text;
          newProduct.Details = this.ProductDetail.Text;
          newProduct.CategoryIndex = this.DropDownList1.SelectedIndex;
          newProduct.Category = this.DropDownList1.Properties().Text;
         newProduct.IsNew = this.ProductNew.Checked;
         newProduct.Odetails = this.ProductOdetailsInput.Text;
         products.Add(newProduct);
         this.GridView1.DataSource = products;
         this.GridView1.DataBind();
     }

      protected void editButton_Click(object sender, EventArgs e)
      {

      }

      protected void GridView1_RowDataBound(object sender, Mobilize.Web.UI.Controls.GridViewRowEventArgs e)
      {
          var combo = e.Row.FindControl("DropDownList2") as Mobilize.Web.UI.Controls.DropDownList;
          var hiddenVar = e.Row.FindControl("HiddenId") as Stub._System.Web.UI.WebControls.HiddenField;
          if (combo!=null && hiddenVar != null)
          {
              var i = int.Parse(hiddenVar.Value);
              combo.SelectedIndex = i;
          }
      }

      protected void GridView1_RowCommand(object sender, Mobilize.Web.UI.Controls.GridViewCommandEventArgs e)
      {
          var btn = e.CommandSource as Mobilize.Web.UI.Controls.Button;
          var grdIndex = btn.NamingContainer as Mobilize.Web.UI.Controls.GridViewRow;
          if (e.CommandName == "save")
          {
              var dropdlist = grdIndex.FindControl("DropDownList2") as Mobilize.Web.UI.Controls.DropDownList;
              var checkGrid = grdIndex.FindControl("isNewCheckbox") as Mobilize.Web.UI.Controls.CheckBox;

              var varId = e.CommandArgument as string;
              var products = this.Session["dataProducts"] as List<Products>;
              foreach (Products p in products)
              {
                  if (p.IdProduct == varId)
                  {
                      p.CategoryIndex = dropdlist.SelectedIndex;
                      p.Category = dropdlist.Properties().Text;
                  p.IsNew = checkGrid.Checked;
                  break;
              }
          }
      }
  }

   }
}