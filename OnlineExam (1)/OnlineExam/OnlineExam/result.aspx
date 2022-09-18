<%@ Page Language="C#" AutoEventWireup="true" CodeFile="result.aspx.cs" Inherits="result" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-decoration: underline;
        }
    </style>
</head>
<body bgcolor="#66ccff">
    <form id="form1" runat="server">
        <div align="center">
            <h1 style="font-family: 'Bahnschrift SemiBold'" class="style1"><em>Online Exam 
                Management System</em></h1>
            <h2 style="font-family: 'Bahnschrift SemiBold'">Result</h2>
            <asp:Panel ID="Panel1" runat="server">
                <div align="center" style="font-size:25px;">
                    <table style="background-color: #FFCCFF">
                        <tr><th>Student Name : </th><td><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td></tr>
                        <tr><th>Student Roll : </th><td><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td></tr>
                        <tr><th>Attempted : </th><td><asp:Label ID="Label3" runat="server" Text=""></asp:Label></td></tr>
                        <tr><th>Unattempted : </th><td><asp:Label ID="Label4" runat="server" Text=""></asp:Label></td></tr>
                        <tr><th>Total Marks : </th><td><asp:Label ID="Label5" runat="server" Text=""></asp:Label></td></tr>
                        <tr><th colspan="2"><asp:Button ID="Button1" runat="server" Text="Finish" OnClick="Button1_Click" /></th></tr>
                    </table>
                </div>
            </asp:Panel>
        </div>
    </form>
</body>

