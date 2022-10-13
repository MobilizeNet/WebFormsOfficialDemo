namespace TestingDemos_WebForms.Features
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.UI.WebControls;
    using TestingDemos_WebForms.Classes.eShop;

    public partial class eShopGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var btnClicked = Request.QueryString["btn"];
                switch (btnClicked)
                {
                    case "edit":
                        this.lblMessage.Text = "You Clicked Edit link";
                        break;
                    case "details":
                        this.lblMessage.Text = "You Clicked Details link";
                        break;
                    case "delete":
                        this.lblMessage.Text = "You Clicked Delete link";
                        break;

                }
            }
            else
            {
                this.lblMessage.Text = "";
            }

            productList.DataSource = GetCatalogItems();
            productList.DataBind();
        }

        private List<CatalogItem> GetCatalogItems()
        {

            return new List<CatalogItem>(){
                new CatalogItem { Id =1, CatalogType = GetType(2), CatalogBrand = GetBrand(2), AvailableStock = 100, RestockThreshold=0, MaxStockThreshold=0, Description = ".NET Bot Black Hoodie", Name = ".NET Bot Black Hoodie", Price = 19.5M , PictureFileName="1.png"},
                new CatalogItem { Id =2, CatalogType = GetType(1), CatalogBrand = GetBrand(2), AvailableStock = 100, RestockThreshold=0, MaxStockThreshold=0, Description = ".NET Black & White Mug", Name = ".NET Black & White Mug", Price= 8.50M , PictureFileName="2.png"},
                new CatalogItem { Id =3, CatalogType = GetType(2), CatalogBrand = GetBrand(5), AvailableStock = 100, RestockThreshold=0, MaxStockThreshold=0, Description = "Prism White T-Shirt", Name = "Prism White T-Shirt", Price = 12, PictureFileName="3.png"},
                new CatalogItem { Id =4, CatalogType = GetType(2), CatalogBrand = GetBrand(2), AvailableStock = 100, RestockThreshold=0, MaxStockThreshold=0, Description = ".NET Foundation T-shirt", Name = ".NET Foundation T-shirt", Price = 12 , PictureFileName="4.png"},
                new CatalogItem { Id =5, CatalogType = GetType(3), CatalogBrand = GetBrand(5), AvailableStock = 100, RestockThreshold=0, MaxStockThreshold=0, Description = "Roslyn Red Sheet", Name = "Roslyn Red Sheet", Price = 8.5M , PictureFileName="5.png"},
                new CatalogItem { Id =6, CatalogType = GetType(2), CatalogBrand = GetBrand(2), AvailableStock = 100, RestockThreshold=0, MaxStockThreshold=0, Description = ".NET Blue Hoodie", Name = ".NET Blue Hoodie", Price = 12, PictureFileName="6.png"},
                new CatalogItem { Id =7, CatalogType = GetType(2), CatalogBrand = GetBrand(5), AvailableStock = 100, RestockThreshold=0, MaxStockThreshold=0, Description = "Roslyn Red T-Shirt", Name = "Roslyn Red T-Shirt", Price = 12, PictureFileName="7.png"},
                new CatalogItem { Id =8, CatalogType = GetType(2), CatalogBrand = GetBrand(5), AvailableStock = 100, RestockThreshold=0, MaxStockThreshold=0, Description = "Kudu Purple Hoodie", Name = "Kudu Purple Hoodie", Price = 8.5M, PictureFileName="8.png"},
                new CatalogItem { Id =9, CatalogType = GetType(1), CatalogBrand = GetBrand(5), AvailableStock = 100, RestockThreshold=0, MaxStockThreshold=0, Description = "Cup<T> White Mug", Name = "Cup<T> White Mug", Price = 12, PictureFileName="9.png"},
                new CatalogItem { Id =10, CatalogType = GetType(3), CatalogBrand = GetBrand(2), AvailableStock = 100, RestockThreshold=0, MaxStockThreshold=0, Description = ".NET Foundation Sheet", Name = ".NET Foundation Sheet", Price = 12, PictureFileName="10.png"},
                new CatalogItem { Id =11, CatalogType = GetType(3), CatalogBrand = GetBrand(2), AvailableStock = 100, RestockThreshold=0, MaxStockThreshold=0, Description = "Cup<T> Sheet", Name = "Cup<T> Sheet", Price = 8.5M, PictureFileName="11.png"},
                new CatalogItem { Id =12, CatalogType = GetType(2), CatalogBrand = GetBrand(5), AvailableStock = 100, RestockThreshold=0, MaxStockThreshold=0, Description = "Prism White TShirt", Name = "Prism White TShirt", Price = 12, PictureFileName="12.png"},
            };
        }

        private CatalogBrand GetBrand(int id)
        {
            var brands = new List<CatalogBrand>()
            {
                new CatalogBrand() { Id =1, Brand = "Azure"},
                new CatalogBrand() { Id =2, Brand = ".NET" },
                new CatalogBrand() { Id =3, Brand = "Visual Studio" },
                new CatalogBrand() { Id =4, Brand = "SQL Server" },
                new CatalogBrand() { Id =5, Brand = "Other" }
            };

            return brands.ElementAtOrDefault(id);
        }

        private CatalogType GetType(int id)
        {
            var types = new List<CatalogType>()
            {
                new CatalogType() { Id =1, Type = "Mug"},
                new CatalogType() { Id =2, Type = "T-Shirt" },
                new CatalogType() { Id =3, Type = "Sheet" },
                new CatalogType() { Id =4, Type = "USB Memory Stick" }
            };

            return types.ElementAtOrDefault(id);
        }

        protected void productList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            productList.PageIndex = e.NewPageIndex;
            productList.DataBind();
        }
    }
}