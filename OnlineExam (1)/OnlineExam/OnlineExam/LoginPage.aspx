<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Login</title>
    <style>
        .div1 {
            height:220px;
            width:200px;
            background-color:rgb(104 204 255);
            margin-top:80px;
            border:1px solid green;
            padding:7px;
        }
    </style>
</head>
<body background="wallpaper.png">
    <form id="form1" runat="server">
        <div align="center">
            <div class="div1" align="center">
                <table border="0" style="background-color: #FFFFCC">
                    <tr><th style="font-size:24px;padding-bottom:15px;">Admin Login</th></tr>
                    <tr><td align="left">Username</td></tr>
                    <tr><th><asp:TextBox ID="TextBox1" runat="server" Font-Size="Larger" Height="25px" Width="188px"></asp:TextBox></th></tr>
                    <tr><td align="left">Password</td></tr>
                    <tr><th><asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="188px" Font-Size="Larger" TextMode="Password"></asp:TextBox></th></tr>
                    <tr><th><asp:Button ID="Button1" runat="server" Text="Login" Height="31px" OnClick="Button1_Click" Width="81px" Font-Size="Medium" /></th></tr>
                    <tr><th><a href="register.aspx">Student Register</a></th></tr>
                </table>
            </div>
        </div>
    </form>
</body>