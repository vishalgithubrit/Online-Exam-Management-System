using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class register : System.Web.UI.Page
{
    OleDbConnection con;
    OleDbCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("C++");
            DropDownList1.Items.Add("JAVA");
            DropDownList1.Items.Add("ASP.NET");
            DropDownList1.Items.Add("WEB");
        }
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
            string name = TextBox1.Text;
            string roll = TextBox2.Text;
            string subject = DropDownList1.SelectedValue;
            cmd = new OleDbCommand("select count(*) from question where subject='" + subject + "'", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i < 10)
            {
                Response.Write("<script>alert('ask admin to create all questions before start exam')</script>");
            }
            else
            {
                cmd = new OleDbCommand("select * from register where roll=" + roll + " and subject='" + subject + "' and name='" + name + "'", con);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Response.Write("<script>alert('you have already taken this test.')</script>");
                }
                else
                {
                    cmd = new OleDbCommand("insert into register values('" + name + "'," + roll + ",'" + subject + "')", con);
                    cmd.ExecuteNonQuery();
                    Session["name"] = TextBox1.Text;
                    Session["roll"] = TextBox2.Text;
                    Session["sub"] = DropDownList1.SelectedValue;
                    Response.Redirect("exam_page.aspx");
                }
            }
        }
    }

}