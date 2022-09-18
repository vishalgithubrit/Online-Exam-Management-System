<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Student Registration</title>
    <style>
        .div1 {
            height:280px;
            width:220px;
            background-color:rgb(0 191 255);
            margin-top:80px;
            border:1px solid green;
            padding:7px;
        }
    </style>
</head>
<body background="download.jpg">
    <form id="form1" runat="server">
        <div align="center">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Untitled1.jpg" 
                style="font-weight: 700; text-decoration: underline" />
            <div class="div1" align="center">
                <table border="0" style="background-color: #CCFFFF">
                    <tr><th style="font-size:30px;padding-bottom:15px;">Registration</th></tr>
                    <tr><td align="left"">Name</td></tr>
                    <tr><th><asp:TextBox ID="TextBox1" runat="server" Font-Size="Larger" Height="25px" Width="188px"></asp:TextBox></th></tr>
                    <tr><td align="left">Roll</td></tr>
                    <tr><th><asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="188px" Font-Size="Larger"></asp:TextBox></th></tr>
                    <tr><td align="left">Subject</td></tr>
                    <tr><th><asp:DropDownList ID="DropDownList1" runat="server" Height="29px" Width="85px"></asp:DropDownList></th></tr>
                    <tr><th><asp:Button ID="Button1" runat="server" Text="Start Exam" Height="40px" OnClick="Button1_Click" Width="129px" Font-Size="Larger" /></th></tr>
                    <tr><th><a href="LoginPage.aspx">Admin login</a></th></tr>
                </table>
            </div>
        </div>
    </form>
</body>