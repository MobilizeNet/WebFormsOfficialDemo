using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestingDemos_WebForms
{
    public partial class GridViewForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack )
            {
                var customers = new List<Customers>();

                Customers customer1 = new Customers();
                Customers customer2 = new Customers();
                Customers customer3 = new Customers();
                customer1.Name = "Katrina Foster";
                customer1.Phone = "(172)-498-3515";
                customer1.Mail = "katrina.foster@example.com";
                customer2.Name = "Daisy Gregory";
                customer2.Phone = "(937)-419-7103";
                customer2.Mail = "daisy.gregory@example.com";
                customer3.Name = "Katherine Reynolds";
                customer3.Phone = "(217)-411-7103";
                customer3.Mail = "katherine.reynolds@example.com";
                customers.Add(customer1);
                customers.Add(customer2);
                customers.Add(customer3);
                this.Session["data"] = customers;
                this.GridView1.DataSource = customers;
                this.GridView1.DataBind();
            }   
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers();
            var custumers = this.Session["data"] as List<Customers>;
            newCustomer.Name = this.name.Text;
            newCustomer.Phone = this.phone.Text;
            newCustomer.Mail = this.mail.Text;
            custumers.Add(newCustomer);
            this.GridView1.DataSource = custumers;
            this.GridView1.DataBind();
        }
    }
}