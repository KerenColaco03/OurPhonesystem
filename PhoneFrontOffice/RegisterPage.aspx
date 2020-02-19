<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterPage.aspx.cs" Inherits="RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 102px;
        }
        .auto-style1 {
            width: 146%;
            height: 468px;
        }
        .auto-style2 {
            width: 264px;
            height: 34px;
        }
        .auto-style3 {
            width: 367px;
            height: 34px;
        }
        .auto-style4 {
            height: 173px;
            width: 717px;
        }
        .auto-style5 {
            z-index: 1;
            left: 313px;
            top: 51px;
            position: absolute;
        }
        .auto-style8 {
            position: absolute;
            top: 81px;
            left: 312px;
            z-index: 1;
            height: 14px;
        }
        .auto-style9 {
            width: 264px;
            height: 27px;
        }
        .auto-style10 {
            width: 367px;
            height: 27px;
        }
        .auto-style11 {
            width: 264px;
            height: 32px;
        }
        .auto-style12 {
            width: 367px;
            height: 32px;
        }
        .auto-style13 {
            width: 264px;
            height: 35px;
        }
        .auto-style14 {
            width: 367px;
            height: 35px;
        }
        .auto-style15 {
            width: 264px;
            height: 31px;
        }
        .auto-style16 {
            width: 367px;
            height: 31px;
        }
        .auto-style17 {
            position: absolute;
            top: 178px;
            left: 316px;
            z-index: 1;
        }
        .auto-style18 {
            position: absolute;
            top: 144px;
            left: 316px;
            z-index: 1;
            height: 13px;
        }
        .auto-style19 {
            position: absolute;
            top: 112px;
            left: 315px;
            z-index: 1;
        }
        .auto-style20 {
            position: absolute;
            top: 211px;
            left: 317px;
            z-index: 1;
        }
        .auto-style21 {
            position: absolute;
            top: 211px;
            left: 176px;
            z-index: 1;
            width: 128px;
            height: 18px;
        }
        .auto-style22 {
            position: absolute;
            top: 142px;
            left: 181px;
            z-index: 1;
            width: 116px;
        }
        .auto-style23 {
            position: absolute;
            top: 176px;
            left: 176px;
            z-index: 1;
            width: 125px;
        }
        .auto-style24 {
            position: absolute;
            top: 75px;
            left: 176px;
            z-index: 1;
            width: 125px;
        }
        .auto-style25 {
            position: absolute;
            top: 110px;
            left: 175px;
            z-index: 1;
            width: 128px;
        }
        .auto-style26 {
            position: absolute;
            top: 44px;
            left: 179px;
            z-index: 1;
            width: 121px;
            height: 15px;
        }
        .auto-style27 {
            z-index: 1;
            left: 348px;
            top: 449px;
            position: absolute;
            height: 28px;
            width: 74px;
        }
        .auto-style28 {
            z-index: 1;
            left: 223px;
            top: 450px;
            position: absolute;
        }
        .auto-style29 {
            position: absolute;
            top: 243px;
            left: 176px;
            z-index: 1;
            height: 19px;
            width: 125px;
        }
        .auto-style30 {
            position: absolute;
            top: 280px;
            left: 179px;
            z-index: 1;
            width: 125px;
        }
        .auto-style31 {
            position: absolute;
            top: 313px;
            left: 178px;
            z-index: 1;
            width: 129px;
        }
        .auto-style32 {
            position: absolute;
            top: 348px;
            left: 175px;
            z-index: 1;
            width: 102px;
            height: 16px;
        }
        .auto-style33 {
            position: absolute;
            top: 341px;
            left: 320px;
            z-index: 1;
        }
        .auto-style34 {
            position: absolute;
            top: 245px;
            left: 320px;
            z-index: 1;
        }
        .auto-style35 {
            position: absolute;
            top: 277px;
            left: 321px;
            z-index: 1;
        }
        .auto-style36 {
            position: absolute;
            top: 307px;
            left: 320px;
            z-index: 1;
        }
        .auto-style37 {
            height: 35px;
        }
    </style>
</head>
<body style="height: 621px">
    <form id="form1" runat="server" class="auto-style4">
        <div>
        </div>
        <asp:Button ID="BtnSubmit" runat="server" CssClass="auto-style28" Text="Submit" />
        <asp:Button ID="BtnCancel" runat="server" CssClass="auto-style27" Text="Cancel" />
        <asp:TextBox ID="txtCustomerID" runat="server" CssClass="auto-style5"></asp:TextBox>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style14"></td>
                <td class="auto-style37">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Register Page"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15"></td>
                <td class="auto-style16"></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15"></td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
        </table>
        <asp:TextBox ID="txtFirstname" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:TextBox ID="txtLastname" runat="server" CssClass="auto-style19"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style18"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style17"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style20"></asp:TextBox>
        <asp:Label ID="lblCustomerID" runat="server" CssClass="auto-style26" Text="CustomerID"></asp:Label>
        <asp:Label ID="lblFirstname" runat="server" CssClass="auto-style24" Text="Firstname"></asp:Label>
        <asp:Label ID="lblLastname" runat="server" CssClass="auto-style25" Text="Lastname"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" CssClass="auto-style22" Text="Email"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" CssClass="auto-style23" Text="Username"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" CssClass="auto-style21" Text="Password"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" CssClass="auto-style29" Text="Postcode"></asp:Label>
        <asp:TextBox ID="txtStreetname" runat="server" CssClass="auto-style36"></asp:TextBox>
        <asp:TextBox ID="txtHouseNo" runat="server" CssClass="auto-style33"></asp:TextBox>
        <asp:TextBox ID="txtCountry" runat="server" CssClass="auto-style35"></asp:TextBox>
        <asp:TextBox ID="txtPostcode" runat="server" CssClass="auto-style34"></asp:TextBox>
        <asp:Label ID="lblStreetname" runat="server" CssClass="auto-style31" Text="Streetname"></asp:Label>
        <asp:Label ID="lblHouseNo" runat="server" CssClass="auto-style32" Text="HouseNo"></asp:Label>
        <asp:Label ID="lblCountry" runat="server" CssClass="auto-style30" Text="Country"></asp:Label>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
