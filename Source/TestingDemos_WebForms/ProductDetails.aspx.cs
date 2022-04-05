using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingDemos_WebForms.Classes;

namespace TestingDemos_WebForms
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["IdProduct"]))
            {
                var id = Request.QueryString["IdProduct"];
                var products = this.Session["dataProducts"] as List<Products>;
                foreach (Products p in products)
                {
                    if (p.IdProduct == id)
                    {
                        this.idLabelInfo.Text = p.IdProduct;
                        this.ProductNameInfoLabel.Text = p.Name;
                        this.ProductDetailInfoLabel.Text = p.Details;
                        this.ProductCategoryInfoLabel.Text = p.Category;
                        this.ProductoDetailsInfoLabel.Text = p.Odetails;
                        break;
                    }
                }
            }
        }
    }
}