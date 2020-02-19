<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 145px;
        }
        .auto-style2 {
            width: 122px;
        }
        .auto-style3 {
            width: 122px;
            height: 35px;
        }
        .auto-style4 {
            height: 35px;
        }
        .auto-style5 {
            width: 122px;
            height: 38px;
        }
        .auto-style6 {
            height: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 360px; width: 728px;">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Login Page"></asp:Label>
&nbsp;<br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" />
                    </td>
                    <td>
                        <asp:Button ID="BtnCancel" runat="server" Text="Cancel" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
