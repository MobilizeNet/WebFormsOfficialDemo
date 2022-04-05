using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingDemos_WebForms.Classes;

namespace TestingDemos_WebForms
{
    public partial class DataListForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Session["dataItems"] = fillTable();
                var items = this.Session["dataItems"] as List<Person>;
                this.DataList1.DataSource = items;
                DataList1.DataBind();
            }
        }

        protected List<Person> fillTable()
        {
            var list = new List<Person>();
            list.Add(new Person { Id = "0001", Name = "John Doe", Email = "johnDoe@mobilize.net" });
            return list;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            addNewRow();
        }

        public void addNewRow() {
            var itemsTable = this.Session["dataItems"] as List<Person>;
            itemsTable.Add(new Person { Id = this.idTextbox.Text, Name = this.nameTextbox.Text, Email = this.emailTextbox.Text });
            this.Session["dataItems"] = itemsTable;
            this.DataList1.DataSource = itemsTable;
            DataList1.DataBind();
        }
    }
}