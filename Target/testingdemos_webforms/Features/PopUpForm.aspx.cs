using System;
using System.Collections.Generic;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace TestingDemos_WebForms.Features
{

   [Observable]
   public partial class PopUpForm : Mobilize.Web.UI.Controls.Page
   {
       protected void Page_Load(object sender, EventArgs e)
       {
           this.informationLabel.Visible = false;
           this.nameSentLabel.Visible = false;
           this.genderSentLabel.Visible = false;
           this.marriedSentLabel.Visible = false;
           this.citySentLabel.Visible = false;
       }

       protected void Button1_Click(object sender, EventArgs e)
       {
           this.informationLabel.Visible = true;
           this.nameSentLabel.Visible = true;
           this.genderSentLabel.Visible = true;
           this.marriedSentLabel.Visible = true;
           this.citySentLabel.Visible = true;
           this.informationLabel.Text = "This is the information sent";
           this.nameSentLabel.Text = "Name: "+this.nameInput.Text;
           this.genderSentLabel.Text = "Gender: "+this.genderDropDown.SelectedItem.Text;
           var flagMarried = (this.MarriedCheckBox.Checked) ? "Married" : "Not married";
           this.marriedSentLabel.Text = flagMarried;
           this.citySentLabel.Text = "City: "+CityInput.Text;
       }

   }
}