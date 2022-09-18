<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_page.aspx.cs" Inherits="admin_page" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <style class="menuitem">
        .menu {
            background-color:rgb(18 11 42);
            height:30px;
            width:100%;
            padding:5px 0px 0px 0px;
        }
        .menuitem{
            text-decoration:none !important;
            color:rgb(243 229 229) !important;
            padding:5px 3px 8px 5px;
            cursor:pointer;
            font-size:20px;
        }
        .menuitem:hover{
            background-color:aqua;
            color:darkslategrey !important;
            transition-duration:250ms;
        }
        .menuitem2{
            text-decoration:none !important;
            color:rgb(243 229 229) !important;
            float:right;
            padding:0px 5px 6px 2px;
            cursor:pointer;
            font-size:20px;
        }
        .menuitem2:hover
        {
            background-color:aqua;
            color:darkslategrey !important;
            transition-duration:250ms;
        }
    </style>
    <title>Admin page</title>
</head>
<body bgcolor="#66FFFF">
    <form id="form1" runat="server">
        <h1 align="center" style="font-family: 'Bahnschrift SemiBold'">Online Exam Management System</h1>
        <h2 align="center" style="font-family: 'Bahnschrift SemiBold'">Admin Page</h2>

        <div class="menu">
            <span><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" CssClass="menuitem">Student Register</asp:LinkButton></span>
            <span><asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" CssClass="menuitem">Student Marks</asp:LinkButton></span>
            <span><asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" CssClass="menuitem">Questions</asp:LinkButton></span>
            <span><asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" CssClass="menuitem2">Log Out</asp:LinkButton></span>
        </div>
        <br />
        <asp:Panel ID="Panel1" runat="server">
            Enter Roll : <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="134px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Search" Font-Size="Medium" Height="27px" Width="69px" OnClick="Button1_Click" />
            <br /><br />Subject : <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"></asp:DropDownList>
            <asp:Button ID="Button2" runat="server" Text="Display All" Font-Size="Medium" Height="27px" Width="91px" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Delete" Font-Size="Medium" Height="27px" Width="91px" OnClick="Button3_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="#CC0000"></asp:Label><br /><br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">Enter Roll : <asp:TextBox ID="TextBox8" runat="server" Height="22px" Width="134px"></asp:TextBox>
            <asp:Button ID="Button6" runat="server" Text="Search" Font-Size="Medium" Height="27px" Width="69px" OnClick="Button6_Click" /><br /><br />
            Subject : <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList>
            <asp:Button ID="Button8" runat="server" Text="Display All" Font-Size="Medium" Height="27px" Width="91px" OnClick="Button8_Click" />
            <asp:Button ID="Button9" runat="server" Text="Delete" Font-Size="Medium" Height="27px" Width="91px" OnClick="Button9_Click" />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="Medium" ForeColor="#CC0000"></asp:Label><br /><br />
            <asp:GridView ID="GridView3" runat="server"></asp:GridView>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server">
            Question : <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="468px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; Enter Question no : <asp:TextBox ID="TextBox7" runat="server" Width="46px"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="Select" OnClick="Button4_Click" /><br /><br />
            Option 1 : <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
            Option 2 : <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
            Option 3 : <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine"></asp:TextBox>
            Option 4 : <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine"></asp:TextBox><br /><br />
            Answer : <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            Subject : <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <asp:Button ID="Button5" runat="server" Text="Add Question" OnClick="Button5_Click" />
            <asp:Button ID="Button7" runat="server" Text="Modify Question" OnClick="Button7_Click" />
            <br /><asp:Label ID="Label2" runat="server" ForeColor="#CC0000"></asp:Label>
            <br /><br /><asp:GridView ID="GridView2" runat="server"></asp:GridView>
        </asp:Panel>
    </form>
    
</body>