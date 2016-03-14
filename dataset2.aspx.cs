using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dataset1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //bind and desplay
        GridView1.DataSource = SqlDataSource1;
        GridView1.DataBind();

    }
}