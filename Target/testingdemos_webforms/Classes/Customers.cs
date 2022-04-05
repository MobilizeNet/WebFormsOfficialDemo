using System;
using System.Collections.Generic;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace TestingDemos_WebForms
{

   [Observable]
   public class Customers
   {

      [Intercepted]
      public string Name { get; set; }

      [Intercepted]
      public string Phone { get; set; }

      [Intercepted]
      public string Mail { get; set; }

   }
}