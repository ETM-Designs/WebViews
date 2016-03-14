using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//don't ever forget to add an option for oleDb
using System.Data.OleDb;

public partial class dataset3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = Server.MapPath("/");
        Response.Write(path);
        string connStr = "Provider=Microsoft.Jet.OLEDB.4.0;" + 
            "DataSource="+path+"\App_Data\\NWIND.mdb";
        OleDbConnection conn = new OleDbConnection(connStr);
        conn.Open();
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = conn;
        cmd.CommandText = "SELECT * FROM [Suppliers]";
        OleDbDataReader dr = cmd.ExecuteReader();
        //bind and display
        GridView1.DataSource = dr;
        GridView1.DataBind();
        dr.Close();
        conn.Close();
    }
}