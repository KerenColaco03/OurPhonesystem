<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterPage.aspx.cs" Inherits="RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            text-align: right;
        }
        .auto-style5 {
            height: 26px;
            text-align: right;
        }
        .auto-style6 {
            height: 23px;
            text-align: right;
        }
        .auto-style7 {
            text-align: right;
            height: 30px;
        }
        .auto-style8 {
            height: 30px;
        }
        .auto-style9 {
            font-size: larger;
        }
    </style>
</head>
<body style="height: 485px">
    <form id="form1" runat="server">
        <div class="auto-style9">
            <strong>Register Page</strong></div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">Firstname</td>
                <td>
                    <asp:TextBox ID="TextBoxFN" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Lastname</td>
                <td>
                    <asp:TextBox ID="TextBoxLN" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Password</td>
                <td>
                    <asp:TextBox ID="TextBoxPass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Email </td>
                <td>
                    <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Username</td>
                <td>
                    <asp:TextBox ID="TextBoxUN" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Streetname</td>
                <td>
                    <asp:TextBox ID="TextBoxStreet" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Houseno </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxHouseNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">County</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxCounty" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Postcode</td>
                <td>
                    <asp:TextBox ID="TextBoxPost" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Country</td>
                <td>
                    <asp:DropDownList ID="DropDownListCountry" runat="server">
                        <asp:ListItem>select country</asp:ListItem>
                        <asp:ListItem>Nigeria</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>UK</asp:ListItem>
                        <asp:ListItem>Ghana</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" Text="Submit" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="btncancel" runat="server" Text="cancel" />
                </td>
            </tr>
        </table>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
