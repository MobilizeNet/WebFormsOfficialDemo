using Mobilize.WebMap.Common.Attributes;

namespace TestingDemos_WebForms.Features
{

   public partial class PopUpForm
{

   private Mobilize.Web.UI.Controls.ListItem ___Build__Control1()
   {
      Mobilize.Web.UI.Controls.ListItem ListItem = new Mobilize.Web.UI.Controls.ListItem();
      ListItem.Text = "Male";
      return ListItem;
   }

   private Mobilize.Web.UI.Controls.ListItem ___Build__Control2()
   {
      Mobilize.Web.UI.Controls.ListItem ListItem = new Mobilize.Web.UI.Controls.ListItem();
      ListItem.Text = "Female";
      return ListItem;
   }

   private Mobilize.Web.UI.Controls.ListItem ___Build__Control3()
   {
      Mobilize.Web.UI.Controls.ListItem ListItem = new Mobilize.Web.UI.Controls.ListItem();
      ListItem.Text = "Other";
      return ListItem;
   }

   private void ___Build___Items0(Mobilize.Web.UI.Controls.ListItemCollection ___lst)
   {
      ___lst.Add(this.___Build__Control1());
      ___lst.Add(this.___Build__Control2());
      ___lst.Add(this.___Build__Control3());
   }

}

}