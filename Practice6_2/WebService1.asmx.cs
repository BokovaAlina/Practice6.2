using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace Practice6_2
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        [WebMethod]

        public DataSet GetCustomers()
        {
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            SqlConnection conn;
            SqlDataAdapter myDataAdapter;
            DataSet myDataSet;
            string cmdString = "Select* From Customers";
            conn = new SqlConnection(str);
            myDataAdapter = new SqlDataAdapter(cmdString, conn);
            myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "Customers");
            return myDataSet;
        }
    }
}
