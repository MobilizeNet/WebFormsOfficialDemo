namespace TestingDemos_WebForms.Classes.eShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class CatalogItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureFileName { get; set; }

        public string CatalogType { get; set; }

        public string CatalogBrand { get; set; }

        public int AvailableStock { get; set; }

        public int RestockThreshold { get; set; }

        public int MaxStockThreshold { get; set; }
    }
}