using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TestingDemos_WebForms
{

   public partial class OtherComponents
   {

      private Mobilize.Web.UI.Controls.ListItem ___Build__Control1()
      {
         Mobilize.Web.UI.Controls.ListItem ListItem = new Mobilize.Web.UI.Controls.ListItem();
         ListItem.Text = "Electronic devices";
         return ListItem;
      }

      private Mobilize.Web.UI.Controls.ListItem ___Build__Control2()
      {
         Mobilize.Web.UI.Controls.ListItem ListItem = new Mobilize.Web.UI.Controls.ListItem();
         ListItem.Text = "Tv & Home Appliances";
         return ListItem;
      }

      private Mobilize.Web.UI.Controls.ListItem ___Build__Control3()
      {
         Mobilize.Web.UI.Controls.ListItem ListItem = new Mobilize.Web.UI.Controls.ListItem();
         ListItem.Text = "Health & Beauty";
         return ListItem;
      }

      private Mobilize.Web.UI.Controls.ListItem ___Build__Control4()
      {
         Mobilize.Web.UI.Controls.ListItem ListItem = new Mobilize.Web.UI.Controls.ListItem();
         ListItem.Text = "Men's Fashion";
         return ListItem;
      }

      private void ___Build___Items0(Mobilize.Web.UI.Controls.ListItemCollection ___lst)
      {
         ___lst.Add(this.___Build__Control1());
         ___lst.Add(this.___Build__Control2());
         ___lst.Add(this.___Build__Control3());
         ___lst.Add(this.___Build__Control4());
      }

      private Mobilize.Web.UI.Controls.BoundField ___Build__Control6()
      {
         Mobilize.Web.UI.Controls.BoundField BoundField = new Mobilize.Web.UI.Controls.BoundField();
         BoundField.HeaderText = "Product ID";
         BoundField.DataField = "IdProduct";
         return BoundField;
      }

      private Mobilize.Web.UI.Controls.BoundField ___Build__Control7()
      {
         Mobilize.Web.UI.Controls.BoundField BoundField = new Mobilize.Web.UI.Controls.BoundField();
         BoundField.HeaderText = "Product Name";
         BoundField.DataField = "Name";
         return BoundField;
      }

      private Mobilize.Web.UI.Controls.Label ___Build__Control10()
      {
         Mobilize.Web.UI.Controls.Label Label = new Mobilize.Web.UI.Controls.Label();
         Label.Name = "Label1";
         Label.Text = System.Convert.ToString(this.Eval("Details"));
         Label.Style = new Mobilize.Web.UI.Controls.CssStyleCollection("text-align: center;");
         return Label;
      }

      private void ___Template__Control9(Mobilize.Web.UI.Controls.Control __cntrl)
      {
         __cntrl.Controls.Add(this.___Build__Control10());
      }

      private Mobilize.Web.UI.Controls.TemplateField ___Build__Control8()
      {
         Mobilize.Web.UI.Controls.TemplateField TemplateField = new Mobilize.Web.UI.Controls.TemplateField();
         TemplateField.HeaderText = "Product details";
         TemplateField.HeaderStyle.HorizontalAlign = Mobilize.Web.UI.Controls.HorizontalAlign.Center;
         TemplateField.ItemTemplate = new Mobilize.Web.UI.CompiledBindableTemplateBuilder(new Mobilize.Web.UI.BuildTemplateMethod(this.___Template__Control9), null);
         return TemplateField;
      }

      private Mobilize.Web.UI.Controls.ListItem ___Build__Control15()
      {
         Mobilize.Web.UI.Controls.ListItem ListItem = new Mobilize.Web.UI.Controls.ListItem();
         ListItem.Text = "Electronic devices";
         return ListItem;
      }

      private Mobilize.Web.UI.Controls.ListItem ___Build__Control16()
      {
         Mobilize.Web.UI.Controls.ListItem ListItem = new Mobilize.Web.UI.Controls.ListItem();
         ListItem.Text = "Tv & Home Appliances";
         return ListItem;
      }

      private Mobilize.Web.UI.Controls.ListItem ___Build__Control17()
      {
         Mobilize.Web.UI.Controls.ListItem ListItem = new Mobilize.Web.UI.Controls.ListItem();
         ListItem.Text = "Health & Beauty";
         return ListItem;
      }

      private Mobilize.Web.UI.Controls.ListItem ___Build__Control18()
      {
         Mobilize.Web.UI.Controls.ListItem ListItem = new Mobilize.Web.UI.Controls.ListItem();
         ListItem.Text = "Men's Fashion";
         return ListItem;
      }

      private void ___Build___Items14(Mobilize.Web.UI.Controls.ListItemCollection ___lst)
      {
         ___lst.Add(this.___Build__Control15());
         ___lst.Add(this.___Build__Control16());
         ___lst.Add(this.___Build__Control17());
         ___lst.Add(this.___Build__Control18());
      }

      private Mobilize.Web.UI.Controls.DropDownList ___Build__Control13()
      {
         Mobilize.Web.UI.Controls.DropDownList DropDownList = new Mobilize.Web.UI.Controls.DropDownList();
         DropDownList.Name = "DropDownList2";
         DropDownList.Width = new Mobilize.Web.UI.Controls.Unit("150px");
         this.___Build___Items14(DropDownList.Items);
         return DropDownList;
      }

      private Stub._System.Web.UI.WebControls.HiddenField ___Build__Control19()
      {
         Stub._System.Web.UI.WebControls.HiddenField HiddenField = new Stub._System.Web.UI.WebControls.HiddenField();
         HiddenField.Name = "HiddenId";
         HiddenField.Value = System.Convert.ToString(this.Eval("CategoryIndex"));
         return HiddenField;
      }

      private void ___Template__Control12(Mobilize.Web.UI.Controls.Control __cntrl)
      {
         __cntrl.Controls.Add(this.___Build__Control13());
         __cntrl.Controls.Add(this.___Build__Control19());
      }

      private Mobilize.Web.UI.Controls.TemplateField ___Build__Control11()
      {
         Mobilize.Web.UI.Controls.TemplateField TemplateField = new Mobilize.Web.UI.Controls.TemplateField();
         TemplateField.HeaderText = "Category";
         TemplateField.ItemTemplate = new Mobilize.Web.UI.CompiledBindableTemplateBuilder(new Mobilize.Web.UI.BuildTemplateMethod(this.___Template__Control12), null);
         return TemplateField;
      }

      private Mobilize.Web.UI.Controls.CheckBox ___Build__Control22()
      {
         Mobilize.Web.UI.Controls.CheckBox CheckBox = new Mobilize.Web.UI.Controls.CheckBox();
         CheckBox.Name = "isNewCheckbox";
         CheckBox.Checked = (System.Boolean)this.Eval("IsNew");
         return CheckBox;
      }

      private void ___Template__Control21(Mobilize.Web.UI.Controls.Control __cntrl)
      {
         __cntrl.Controls.Add(this.___Build__Control22());
      }

      private Mobilize.Web.UI.Controls.TemplateField ___Build__Control20()
      {
         Mobilize.Web.UI.Controls.TemplateField TemplateField = new Mobilize.Web.UI.Controls.TemplateField();
         TemplateField.HeaderText = "New";
         TemplateField.ItemTemplate = new Mobilize.Web.UI.CompiledBindableTemplateBuilder(new Mobilize.Web.UI.BuildTemplateMethod(this.___Template__Control21), null);
         return TemplateField;
      }

      private Mobilize.Web.UI.Controls.HyperLinkField ___Build__Control23()
      {
         Mobilize.Web.UI.Controls.HyperLinkField HyperLinkField = new Mobilize.Web.UI.Controls.HyperLinkField();
         HyperLinkField.Text = "Details...";
         HyperLinkField.DataNavigateUrlFields = new System.String[] { "IdProduct" };
         HyperLinkField.DataNavigateUrlFormatString = "TestingDemos_WebForms.ProductDetails?IdProduct={0}";
         HyperLinkField.HeaderText = "Order Details";
         return HyperLinkField;
      }

      private Mobilize.Web.UI.Controls.CommandField ___Build__Control24()
      {
         Mobilize.Web.UI.Controls.CommandField CommandField = new Mobilize.Web.UI.Controls.CommandField();
         CommandField.HeaderText = "Edit Controls";
         return CommandField;
      }

      private Mobilize.Web.UI.Controls.Button ___Build__Control27()
      {
         Mobilize.Web.UI.Controls.Button Button = new Mobilize.Web.UI.Controls.Button();
         Button.Name = "SaveButton";
         Button.Text = "Save";
         Button.Properties().CommandName = "save";
         Button.Properties().CommandArgument = System.Convert.ToString(this.Eval("IdProduct"));
         return Button;
      }

      private void ___Template__Control26(Mobilize.Web.UI.Controls.Control __cntrl)
      {
         __cntrl.Controls.Add(this.___Build__Control27());
      }

      private Mobilize.Web.UI.Controls.TemplateField ___Build__Control25()
      {
         Mobilize.Web.UI.Controls.TemplateField TemplateField = new Mobilize.Web.UI.Controls.TemplateField();
         TemplateField.HeaderText = "Save";
         TemplateField.ItemTemplate = new Mobilize.Web.UI.CompiledBindableTemplateBuilder(new Mobilize.Web.UI.BuildTemplateMethod(this.___Template__Control26), null);
         return TemplateField;
      }

      private void ___Build__GridColumns5(Mobilize.Web.UI.Controls.DataControlFieldCollection lst__cntrl)
      {
         lst__cntrl.Add(this.___Build__Control6());
         lst__cntrl.Add(this.___Build__Control7());
         lst__cntrl.Add(this.___Build__Control8());
         lst__cntrl.Add(this.___Build__Control11());
         lst__cntrl.Add(this.___Build__Control20());
         lst__cntrl.Add(this.___Build__Control23());
         lst__cntrl.Add(this.___Build__Control24());
         lst__cntrl.Add(this.___Build__Control25());
      }

   }

}