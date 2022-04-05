using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingDemos_WebForms.Classes
{
    public class Products
    {
        public string IdProduct { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Category { get; set; }
        public int CategoryIndex { get; set; }
        public bool IsNew { get; set; }
        public string Odetails { get; set; }
    }
}