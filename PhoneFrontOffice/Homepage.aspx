<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 223px;
            height: 224px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="" class="auto-style1" src="Logo/Logo.png" /><br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 813px; top: 19px; position: absolute" Text="customer Log in" />
            <br />
            We’ve been selling mobile phones to happy customers for over 20 years, and we like to think we know a thing or two about it. EE, one of the key networks we work with, seems to agree, naming us its Best Retailer from 2016-2018 and Best for Service 2018. One of the key reasons for winning the awards is our customer satisfaction. Which is something we think is really important, because we know it’s important to you. Whether it’s providing a quick and easy ordering process, offering free next-day delivery, or having friendly staff on hand to help when it’s needed, we’re only satisfied when you’re satisfied.
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnShopProducts" runat="server" style="z-index: 1; left: 784px; top: 76px; position: absolute; height: 35px; width: 149px" Text="Browse Products" OnClick="btnShopProducts_Click" />
            <br />
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 380px; top: 91px; position: absolute" Text="Phones4Less LTD" Font-Names="Century Gothic"></asp:Label>
        <asp:Button ID="btnStaffLogin" runat="server" style="z-index: 1; left: 593px; top: 19px; position: absolute" Text="Staff Log in" />
        <asp:Button ID="btnSignUp" runat="server" style="z-index: 1; left: 722px; top: 19px; position: absolute" Text="Sign up" />
        <asp:Label ID="lblAbout" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" style="z-index: 1; left: 470px; top: 273px; position: absolute" Text="About"></asp:Label>
    </form>
</body>
</html>
