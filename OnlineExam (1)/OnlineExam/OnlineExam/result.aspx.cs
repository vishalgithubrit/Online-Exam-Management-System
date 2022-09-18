using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["name"].ToString();
        Label2.Text = Session["roll"].ToString();
        Label3.Text = Session["atmp"].ToString();
        Label4.Text = Convert.ToString(10 - Convert.ToInt32(Session["atmp"]));
        Label5.Text = Session["mrks"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("register.aspx");
    }
}