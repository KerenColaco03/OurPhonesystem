<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Iphone11Pro.aspx.cs" Inherits="Iphone11Pro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 305px;
            height: 250px;
        }
        .auto-style2 {
            position: absolute;
            top: 360px;
            left: 10px;
        }
        .auto-style3 {
            position: absolute;
            top: 363px;
            left: 214px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 398px;
            left: 212px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 438px;
            left: 107px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 438px;
            left: 216px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 506px;
            left: 53px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 506px;
            left: 252px;
            z-index: 1;
            width: 136px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 70px; top: 47px; position: absolute; bottom: 787px;" Text="Iphone 11 Pro"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <img class="auto-style1" src="Logo/iphone11pro.jpg" /></p>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 387px; top: 174px; position: absolute" Text="£1050"></asp:Label>
        <asp:Label ID="Label5" runat="server" CssClass="auto-style2" Font-Bold="True" style="z-index: 1; left: 335px; top: 173px; position: absolute; right: 1134px;" Text="Price:"></asp:Label>
        <asp:Label ID="lblCapacity" runat="server" Font-Bold="True" style="z-index: 1; left: 99px; top: 361px; position: absolute" Text="Capacity"></asp:Label>
        <asp:Label runat="server" CssClass="auto-style5" Font-Bold="True" Text="Brand"></asp:Label>
        <asp:Label ID="lblColour" runat="server" Font-Bold="True" style="z-index: 1; left: 104px; top: 399px; position: absolute" Text="Colour"></asp:Label>
        <asp:Label ID="lbl128gb" runat="server" CssClass="auto-style3" Text="128gb"></asp:Label>
        <asp:Label ID="lblSpacegrey" runat="server" CssClass="auto-style4" Text="Space Grey"></asp:Label>
        <p>
            <asp:Label ID="Label7" runat="server" CssClass="auto-style6" Font-Bold="False" Text="Apple"></asp:Label>
        </p>
        <asp:Button ID="btnContinueShopping" runat="server" CssClass="auto-style7" Text="Continue Shopping" OnClick="btnContinueShopping_Click" />
        <asp:Button ID="btnAddToCart" runat="server" CssClass="auto-style8" OnClick="btnAddToCart_Click" Text="Add to Cart" />
    </form>
</body>
</html>
