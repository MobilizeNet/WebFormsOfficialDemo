using System;
using System.Collections.Generic;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace TestingDemos_WebForms.Classes
{

   [Observable]
   public class Products
   {

      [Intercepted]
      public string IdProduct { get; set; }

      [Intercepted]
      public string Name { get; set; }

      [Intercepted]
      public string Details { get; set; }

      [Intercepted]
      public string Category { get; set; }

      [Intercepted]
      public int CategoryIndex { get; set; }

      [Intercepted]
      public bool IsNew { get; set; }

      [Intercepted]
      public string Odetails { get; set; }

   }
}