using System;
using System.Collections.Generic;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace TestingDemos_WebForms.Classes
{

   [Observable]
   public class ClassItemsL
   {

      [Intercepted]
      public int Id { get; set; }

      [Intercepted]
      public string Description { get; set; }

   }
}