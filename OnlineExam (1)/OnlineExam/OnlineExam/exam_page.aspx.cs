using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Drawing;
public partial class exam_page : System.Web.UI.Page
{
    OleDbConnection con;
    OleDbCommand cmd;
    Button[] bt;
    string[] qno;

    protected void Page_Load(object sender, EventArgs e)
    {
        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("exam.accdb"));
        qno = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        bt = new Button[] { q1, q2, q3, q4, q5, q6, q7, q8, q9, q10 };
        if (Session["qno"] == null)
        {
            Session["ans"] = 0;
            Session["qno"] = 1;
        }
        if (!IsPostBack)
        {
            for (int i = 0; i < 10; i++)
            {
                bt[i].ForeColor = Color.White;
                bt[i].BackColor = Color.OrangeRed;
            }
            headline.InnerText = "Online Exam of " + Session["sub"];
            Panel1.Visible = true;
            show_qn();
        }
        Timer1.Interval = 1000;
        //Response.Write("<script>alert('"+ name +","+ roll +","+ subject +"')</script>");
    }
    protected void show_qn()
    {
        int no = Convert.ToInt32(Session["qno"]);
        con.Open();
        cmd = new OleDbCommand("select * from question where qno=" + Session["qno"] + " and subject='" + Session["sub"] + "'", con);
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Label1.Text = dr.GetString(1);
            op1.Text = dr.GetString(2);
            op2.Text = dr.GetString(3);
            op3.Text = dr.GetString(4);
            op4.Text = dr.GetString(5);
        }
        con.Close();
        if (Session[qno[no - 1]] != null)
        {
            RadioButtonList1.SelectedIndex = Convert.ToInt32(Session[qno[no - 1]]) - 1;
        }
        else
        {
            RadioButtonList1.ClearSelection();
        }
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (Session["second"] == null)
        {
            Session["minute"] = 5;
            Session["second"] = 0;
        }
        int minute = Convert.ToInt32(Session["minute"]), second = Convert.ToInt32(Session["second"]);
        if (minute == 0 && second == 0)
        {
            minute = -1;
            second = -1;
            Session["minute"] = minute;
            Session["second"] = second;
            ans_check();

        }
        else
        {
            if (second == 0)
            {
                second = 59;
                minute--;
                if (minute == 0)
                {
                    time.ForeColor = Color.Red;
                }
            }
            else
            {
                second--;
            }
            time.Text = minute.ToString() + " : " + second.ToString();
            Session["minute"] = minute;
            Session["second"] = second;
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int qno = Convert.ToInt32(Session["qno"]);
        qn_check(qno);
        if (qno > 1)
        {
            qno--;
            Session["qno"] = qno;
            show_qn();
        }
    }

    protected void qn_check(int no)
    {
        if (RadioButtonList1.SelectedIndex == -1)
        {
            bt[no - 1].BackColor = Color.OrangeRed;
        }
        else
        {
            Session[qno[no - 1]] = RadioButtonList1.SelectedIndex + 1;
            bt[no - 1].BackColor = Color.Green;
        }
        attmpt();
    }

    protected void attmpt()
    {
        int c = 0;
        for (int i = 0; i < 10; i++)
        {
            if (Session[qno[i]] != null)
            {
                c++;
            }
        }
        Label2.Text = Convert.ToString(c);
        Label3.Text = Convert.ToString(10 - c);

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int qno = Convert.ToInt32(Session["qno"]);
        qn_check(qno);
        if (qno < 10)
        {
            qno++;
            Session["qno"] = qno;
            show_qn();
        }
    }

    protected void ans_check()
    {
        int c = 0, ans = 0;
        qn_check(Convert.ToInt32(Session["qno"]));
        con.Open();
        cmd = new OleDbCommand("select qno,ans from question where subject='" + Session["sub"] + "'", con);
        OleDbDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            int i = dr.GetInt32(0);
            if (Session[qno[i - 1]] != null)
            {
                c++;
                if (Session[qno[i - 1]].ToString() == dr.GetString(1))
                {
                    ans++;
                }
            }
        }
        cmd = new OleDbCommand("insert into studentinfo values('" + Session["name"] + "'," + Session["roll"] + "," + c + "," + Convert.ToString(10 - c) + "," + ans + ",'" + Session["sub"] + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        Session["atmp"] = Label2.Text;
        Session["mrks"] = ans.ToString();
        Response.Redirect("result.aspx");
    }

    protected void q1_Click(object sender, EventArgs e)
    {
        qn_check(Convert.ToInt32(Session["qno"]));
        Session["qno"] = 1;
        show_qn();
    }

    protected void q2_Click(object sender, EventArgs e)
    {
        qn_check(Convert.ToInt32(Session["qno"]));
        Session["qno"] = 2;
        show_qn();
    }

    protected void q3_Click(object sender, EventArgs e)
    {
        qn_check(Convert.ToInt32(Session["qno"]));
        Session["qno"] = 3;
        show_qn();
    }

    protected void q4_Click(object sender, EventArgs e)
    {
        qn_check(Convert.ToInt32(Session["qno"]));
        Session["qno"] = 4;
        show_qn();
    }

    protected void q5_Click(object sender, EventArgs e)
    {
        qn_check(Convert.ToInt32(Session["qno"]));
        Session["qno"] = 5;
        show_qn();
    }

    protected void q6_Click(object sender, EventArgs e)
    {
        qn_check(Convert.ToInt32(Session["qno"]));
        Session["qno"] = 6;
        show_qn();
    }

    protected void q7_Click(object sender, EventArgs e)
    {
        qn_check(Convert.ToInt32(Session["qno"]));
        Session["qno"] = 7;
        show_qn();
    }

    protected void q8_Click(object sender, EventArgs e)
    {
        qn_check(Convert.ToInt32(Session["qno"]));
        Session["qno"] = 8;
        show_qn();
    }

    protected void q9_Click(object sender, EventArgs e)
    {
        qn_check(Convert.ToInt32(Session["qno"]));
        Session["qno"] = 9;
        show_qn();
    }

    protected void q10_Click(object sender, EventArgs e)
    {
        qn_check(Convert.ToInt32(Session["qno"]));
        Session["qno"] = 10;
        show_qn();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        qn_check(Convert.ToInt32(Session["qno"]));
        ans_check();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        ans_check();
    }

}