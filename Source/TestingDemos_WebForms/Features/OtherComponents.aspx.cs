using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingDemos_WebForms.Classes;

namespace TestingDemos_WebForms
{
    public partial class OtherComponents : System.Web.UI.Page
    {
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
            newProduct.Category = this.DropDownList1.Text;
            newProduct.IsNew = this.ProductNew.Checked;
            newProduct.Odetails = this.ProductOdetailsInput.Text;
            products.Add(newProduct);
            this.GridView1.DataSource = products;
            this.GridView1.DataBind();
        }

        protected void editButton_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            var combo = e.Row.FindControl("DropDownList2") as DropDownList;
            var hiddenVar = e.Row.FindControl("HiddenId") as HiddenField;
            if (combo!=null && hiddenVar != null)
            {
                var i = int.Parse(hiddenVar.Value);
                combo.SelectedIndex = i;
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var btn = e.CommandSource as Button;
            var grdIndex = btn.NamingContainer as GridViewRow;
            if (e.CommandName == "save")
            {
                var dropdlist = grdIndex.FindControl("DropDownList2") as DropDownList;
                var checkGrid = grdIndex.FindControl("isNewCheckbox") as CheckBox;

                var varId = e.CommandArgument as string;
                var products = this.Session["dataProducts"] as List<Products>;
                foreach (Products p in products)
                {
                    if (p.IdProduct == varId)
                    {
                        p.CategoryIndex = dropdlist.SelectedIndex;
                        p.Category = dropdlist.Text;
                        p.IsNew = checkGrid.Checked;
                        break;
                    }
                }
            }
        }
    }
}