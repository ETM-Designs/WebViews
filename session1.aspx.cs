using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class session1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create session variables
        Session["myInt"] = 5;
        Session["myDouble"] = 99.99;
        Session["myString"] = "ETM";
        Response.Redirect("sission2.aspx");
    }
}