<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exam_page.aspx.cs" Inherits="exam_page" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Online Exam</title>
    <style>
        .q_div{
            font-size:20px;
            width:750px;
            height:fit-content;
            word-wrap:break-word;
        }
        .p1 {
            display:flex;
        }
        .t_div{
            border:1px solid purple;
            font-size:20px;
        }
        .btn {
            font-size:large;
            height:33px;
            width:33px;
        }
        .style1
        {
            text-decoration: underline;
            color: #003300;
        }
        .style2
        {
            background-color: #CCFFFF;
        }
    </style>
</head>
<body onload="time_run()" bgcolor="#66ccff">
    <form id="form1" runat="server">
        <div align="center">
            <h1 style="font-family: 'Bahnschrift SemiBold'" class="style1"><em>
                <span class="style2">Online Exam Management System</span></em></h1>
            <h2 runat="server" id="headline"></h2>
        </div>
            <asp:Panel ID="Panel1" runat="server" CssClass="p1">
                <div class="q_div">
                    <b>Question : </b><asp:Label ID="Label1" runat="server" Text="Question"></asp:Label>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" CellSpacing="5">
                        <asp:ListItem Value="1" runat="server" id="op1">option 1</asp:ListItem>
                        <asp:ListItem Value="2" runat="server" id="op2">option 2</asp:ListItem>
                        <asp:ListItem Value="3" runat="server" id="op3">option 3</asp:ListItem>
                        <asp:ListItem Value="4" runat="server" id="op4">option 4</asp:ListItem>
                    </asp:RadioButtonList><br />
                    <asp:Button ID="Button1" runat="server" Text="Previous" Font-Size="Medium" Height="31px" Width="90px" OnClick="Button1_Click" />
                    <div style="float:right;"><asp:Button ID="Button2" runat="server" Text="Next" Font-Size="Medium" Height="31px" Width="90px" OnClick="Button2_Click" /></div>
                </div>
                <div style="width:300px"></div>
                <div class="t_div"><br />
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <table>
                        <tr><td colspan="2">Time =</td><td colspan="3"> 
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:Label ID="time" runat="server" Text=""></asp:Label>
                                    <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick"></asp:Timer>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            </td></tr>
                        <tr><td colspan="5">Attempted : <asp:Label ID="Label2" runat="server" Text=""></asp:Label></td></tr>
                        <tr><td colspan="5">Unattempted : <asp:Label ID="Label3" runat="server" Text=""></asp:Label></td></tr>
                        <tr><td><br /></td></tr><tr>
                            <td><asp:Button ID="q1" runat="server" Text="1" CssClass="btn" OnClick="q1_Click" /></td>
                            <td><asp:Button ID="q2" runat="server" Text="2" CssClass="btn" OnClick="q2_Click" /></td>
                            <td><asp:Button ID="q3" runat="server" Text="3" CssClass="btn" OnClick="q3_Click" /></td>
                            <td><asp:Button ID="q4" runat="server" Text="4" CssClass="btn" OnClick="q4_Click" /></td>
                            <td><asp:Button ID="q5" runat="server" Text="5" CssClass="btn" OnClick="q5_Click" /></td>
                        </tr><tr>
                            <td><asp:Button ID="q6" runat="server" Text="6" CssClass="btn" OnClick="q6_Click" /></td>
                            <td><asp:Button ID="q7" runat="server" Text="7" CssClass="btn" OnClick="q7_Click" /></td>
                            <td><asp:Button ID="q8" runat="server" Text="8" CssClass="btn" OnClick="q8_Click" /></td>
                            <td><asp:Button ID="q9" runat="server" Text="9" CssClass="btn" OnClick="q9_Click" /></td>
                            <td><asp:Button ID="q10" runat="server" Text="10" CssClass="btn" OnClick="q10_Click" /></td>
                        </tr><tr><td><br /></td></tr><tr>
                            <th colspan="5"><asp:Button ID="Button3" runat="server" Text="Submit" Font-Size="Larger" Height="35px" Width="90px" OnClick="Button3_Click" /></th>
                        </tr>
                    </table>
                </div>
            </asp:Panel>
    </form>
</body>