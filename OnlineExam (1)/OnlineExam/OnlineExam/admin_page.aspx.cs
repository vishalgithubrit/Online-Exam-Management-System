using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class admin_page : System.Web.UI.Page
{
    OleDbConnection con;
    OleDbCommand cmd;
    
    protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                DropDownList1.Items.Add("1");
                DropDownList1.Items.Add("2");
                DropDownList1.Items.Add("3");
                DropDownList1.Items.Add("4");
                DropDownList2.Items.Add("C++");
                DropDownList2.Items.Add("JAVA");
                DropDownList2.Items.Add("ASP.NET");
                DropDownList2.Items.Add("WEB");
                DropDownList3.Items.Add("C++");
                DropDownList3.Items.Add("JAVA");
                DropDownList3.Items.Add("ASP.NET");
                DropDownList3.Items.Add("WEB");
                DropDownList4.Items.Add("C++");
                DropDownList4.Items.Add("JAVA");
                DropDownList4.Items.Add("ASP.NET");
                DropDownList4.Items.Add("WEB");
            }
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("exam.accdb"));
        }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label1.Text = "enter roll please.";
        }
        else
        {
            Label1.Text = "";
            con.Open();
            cmd = new OleDbCommand("select * from register where subject='" + DropDownList4.SelectedValue + "' and roll=" + TextBox1.Text, con);
            OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        disp_registration();
    }

    protected void disp_registration()
    {
        Label1.Text = "";
        con.Open();
        cmd = new OleDbCommand("select * from register where subject='" + DropDownList4.SelectedValue + "'", con);
        OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dp.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        con.Close();
    }

    protected void disp_studentinfo()
    {
        Label3.Text = "";
        con.Open();
        cmd = new OleDbCommand("select * from studentinfo where subject ='" + DropDownList3.SelectedValue + "'", con);
        OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dp.Fill(dt);
        GridView3.DataSource = dt;
        GridView3.DataBind();
        con.Close();
    }

    protected void disp_question()
    {
        Label2.Text = "";
        string sub = DropDownList2.SelectedValue;
        con.Open();
        cmd = new OleDbCommand("select * from question where subject='" + sub + "'", con);
        OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dp.Fill(dt);
        GridView2.DataSource = dt;
        GridView2.DataBind();
        con.Close();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        disp_registration();
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = true;
        Panel3.Visible = false;
        disp_studentinfo();
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        disp_question();
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("LoginPage.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label1.Text = "enter roll please.";
        }
        else
        {
            con.Open();
            cmd = new OleDbCommand("delete from register where subject='" + DropDownList4.SelectedValue + "' and roll=" + TextBox1.Text, con);
            int a = cmd.ExecuteNonQuery();
            if (a == 0)
            {
                Response.Write("<script>alert('no data found.')</script>");
            }
            con.Close();
            disp_registration();
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "")
        {
            Response.Write("<script>alert('fill all the fields')</script>");
        }
        else
        {
            string sub, question, op1, op2, op3, op4, ans;
            int count;
            con.Open();
            sub = DropDownList2.SelectedValue;
            cmd = new OleDbCommand("select count(*) from question where subject='" + sub + "'", con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count >= 10)
            {
                Response.Write("<script>alert('Maximum question reached')</script>");
            }
            else
            {
                count++;
                question = TextBox2.Text;
                op1 = TextBox3.Text;
                op2 = TextBox4.Text;
                op3 = TextBox5.Text;
                op4 = TextBox6.Text;
                ans = DropDownList1.SelectedValue;
                cmd = new OleDbCommand("insert into question values(" + count + ",'" + question + "','" + op1 + "','" + op2 + "','" + op3 + "','" + op4 + "','" + ans + "','" + sub + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                disp_question();
            }
        }
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        disp_question();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if (TextBox7.Text == "")
        {
            Label2.Text = "enter Question number please.";
        }
        else
        {
            con.Open();
            cmd = new OleDbCommand("select * from question where qno=" + TextBox7.Text + " and subject='" + DropDownList2.SelectedValue + "'", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["qn"] = Convert.ToInt32(TextBox7.Text);
                Session["sb"] = DropDownList2.SelectedValue;
                TextBox2.Text = dr.GetString(1);
                TextBox3.Text = dr.GetString(2);
                TextBox4.Text = dr.GetString(3);
                TextBox5.Text = dr.GetString(4);
                TextBox6.Text = dr.GetString(5);
                DropDownList1.SelectedIndex = Convert.ToInt32(dr.GetString(6)) - 1;
            }
            con.Close();
        }
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "")
        {
            Label2.Text = "fill all the fields!";
        }
        else
        {
            string question, op1, op2, op3, op4, ans, sb = Session["sb"].ToString(), qn = Session["qn"].ToString();
            if (sb != DropDownList2.SelectedValue)
            {
                Label2.Text = "Subject change is not allowed!";
            }
            else
            {
                con.Open();
                question = TextBox2.Text;
                op1 = TextBox3.Text;
                op2 = TextBox4.Text;
                op3 = TextBox5.Text;
                op4 = TextBox6.Text;
                ans = DropDownList1.SelectedValue;
                cmd = new OleDbCommand("update question set question='" + question + "',op1='" + op1 + "',op2='" + op2 + "',op3='" + op3 + "',op4='" + op4 + "',ans='" + ans + "' where qno=" + qn + " and subject='" + sb + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                disp_question();
            }
        }
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        if (TextBox8.Text == "")
        {
            Label3.Text = "enter roll please.";
        }
        else
        {
            Label3.Text = "";
            con.Open();
            cmd = new OleDbCommand("select * from studentinfo where sturoll=" + TextBox8.Text + " and subject ='" + DropDownList3.SelectedValue + "'", con);
            OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            GridView3.DataSource = dt;
            GridView3.DataBind();
            con.Close();
        }
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        disp_studentinfo();
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        if (TextBox8.Text == "")
        {
            Label3.Text = "enter roll please.";
        }
        else
        {
            con.Open();
            cmd = new OleDbCommand("delete from studentinfo where sturoll=" + TextBox8.Text + " and subject='" + DropDownList3.SelectedValue + "'", con);
            int a = cmd.ExecuteNonQuery();
            if (a == 0)
            {
                Response.Write("<script>alert('no data found.')</script>");
            }
            con.Close();
            disp_studentinfo();
        }
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        disp_studentinfo();
    }

    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        disp_registration();
    }
}