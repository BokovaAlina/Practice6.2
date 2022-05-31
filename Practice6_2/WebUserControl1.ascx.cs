using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Practice6_2
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void OpenCust_Click(object sender, EventArgs e)
        {
            WebService1 ws = new WebService1();
            GridView1.DataSource = ws.GetCustomers();
            GridView1.DataBind();
        }

        protected void Kesh_Click(object sender, EventArgs e)
        {

            DataView Source;
            Source = (DataView)Cache["MyCache"];
            if (Source == null)
            {
                SqlConnection myConnection = new SqlConnection
                (System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString);
                SqlDataAdapter myCommand = new SqlDataAdapter("Select* From Customers", myConnection);
                DataSet ds = new DataSet();
                myCommand.Fill(ds, "Customers");
                Source = new DataView(ds.Tables["Customers"]); Cache["MyCache"] = Source;
                CacheMsg.Text = "Dataset created from Table";
            }
            else
            {
                CacheMsg.Text = "Dataset retrieved from Cache";
            }
            GridView2.DataSource = Source;
            GridView2.DataBind();
        }
    }
}