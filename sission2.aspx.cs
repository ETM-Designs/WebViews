using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class sission2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int myInt = Convert.ToInt32(Session["myInt"]);
        double myDouble = Convert.ToDouble(Session["mydouble"]);
        string myString = Session["myString"].ToString();
        Response.Write("myInt = " + myInt + "<br/>");
        Response.Write("myDouble = " + myDouble + "<br/>");
        Response.Write("myString = " + myString);
    }
}