using System;
using System.Collections.Generic;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace TestingDemos_WebForms.Classes
{

   [Observable]
   public class Person
   {

      [Intercepted]
      public string Id { get; set; }

      [Intercepted]
      public string Name { get; set; }

      [Intercepted]
      public string Email { get; set; }

   }
}