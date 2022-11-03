using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TestingDemos_WebForms
{

   public partial class DataListForm
   {

      private void ___DataBinding___control2(object sender, System.EventArgs e)
      {
         Mobilize.Web.UI.Controls.Label Label = (Mobilize.Web.UI.Controls.Label)sender;
         Mobilize.Web.UI.IDataItemContainer Container = (Mobilize.Web.UI.IDataItemContainer)
            Label.BindingContainer;
         if ( this.Page.GetDataItem() == null )
            return ;
         Label.Text = System.Convert.ToString(this.Eval("Id"));
      }

      private Mobilize.Web.UI.Controls.Label ___Build__Control1()
      {
         Mobilize.Web.UI.Controls.Label Label = new Mobilize.Web.UI.Controls.Label();
         Label.Name = "Label5";
         Label.DataBinding += new System.EventHandler(this.___DataBinding___control2);
         return Label;
      }

      private void ___DataBinding___control4(object sender, System.EventArgs e)
      {
         Mobilize.Web.UI.Controls.Label Label = (Mobilize.Web.UI.Controls.Label)sender;
         Mobilize.Web.UI.IDataItemContainer Container = (Mobilize.Web.UI.IDataItemContainer)
            Label.BindingContainer;
         if ( this.Page.GetDataItem() == null )
            return ;
         Label.Text = System.Convert.ToString(this.Eval("Name"));
      }

      private Mobilize.Web.UI.Controls.Label ___Build__Control3()
      {
         Mobilize.Web.UI.Controls.Label Label = new Mobilize.Web.UI.Controls.Label();
         Label.Name = "Label4";
         Label.DataBinding += new System.EventHandler(this.___DataBinding___control4);
         return Label;
      }

      private void ___DataBinding___control6(object sender, System.EventArgs e)
      {
         Mobilize.Web.UI.Controls.Label Label = (Mobilize.Web.UI.Controls.Label)sender;
         Mobilize.Web.UI.IDataItemContainer Container = (Mobilize.Web.UI.IDataItemContainer)
            Label.BindingContainer;
         if ( this.Page.GetDataItem() == null )
            return ;
         Label.Text = System.Convert.ToString(this.Eval("Email"));
      }

      private Mobilize.Web.UI.Controls.Label ___Build__Control5()
      {
         Mobilize.Web.UI.Controls.Label Label = new Mobilize.Web.UI.Controls.Label();
         Label.Name = "Label7";
         Label.DataBinding += new System.EventHandler(this.___DataBinding___control6);
         return Label;
      }

      private void ____Build_Control0(Mobilize.Web.UI.Controls.Control cntrl)
      {
         cntrl.Controls.Add(this.___Build__Control1());
         cntrl.Controls.Add(this.___Build__Control3());
         cntrl.Controls.Add(this.___Build__Control5());
      }

   }

}