using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class LoginPage : System.Web.UI.Page
{
    OleDbConnection con;
    OleDbCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("exam.accdb"));
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        if (TextBox1.Text == "" || TextBox2.Text == "")
        {
            Response.Write("<script>alert('fill all the fields')</script>");
        }
        else
        {
            string uname = TextBox1.Text;
            string password = TextBox2.Text;
            cmd = new OleDbCommand("select * from admin where uname='" + uname + "' and password='" + password + "'", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("admin_page.aspx");
            }
            else
            {
                Response.Write("<script>alert('Username or password is incorrect!')</script>");
            }
        }
    }
}
