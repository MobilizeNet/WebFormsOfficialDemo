using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestingDemos_WebForms.Features
{
    public partial class CalendarForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int[] MonthList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] DayList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27 };
            int[] YearList = { 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2021, 2022 };
            int month = random.Next(11);
            int day = random.Next(26);
            int year = random.Next(8);
            this.TextBox1.Text = MonthList[month] + "/" + DayList[day] + "/" + YearList[year];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var flag = (this.TextBox1.Enabled) ? false : true;
            this.TextBox1.Enabled = flag;
        }
    }
}