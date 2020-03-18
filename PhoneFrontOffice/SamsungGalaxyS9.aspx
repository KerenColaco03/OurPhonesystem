<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SamsungGalaxyS9.aspx.cs" Inherits="SamsungGalaxyS9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 330px;
            height: 313px;
        }
        .auto-style2 {
            position: absolute;
            top: 360px;
            left: 10px;
        }
        .auto-style5 {
            position: absolute;
            top: 496px;
            left: 112px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 390px;
            left: 215px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 436px;
            left: 214px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 495px;
            left: 208px;
            z-index: 1;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSamsungGalaxy" runat="server" Font-Size="X-Large" style="z-index: 1; left: 70px; top: 47px; position: absolute; bottom: 590px;" Text="Samsung Galaxy S9"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <img alt="" class="auto-style1" src="Logo/Samsung-Galaxy-S9-64GB.jpg" /></p>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 387px; top: 174px; position: absolute" Text="£800"></asp:Label>
        <asp:Label ID="Label5" runat="server" CssClass="auto-style2" Font-Bold="True" style="z-index: 1; left: 335px; top: 173px; position: absolute; right: 931px;" Text="Price:"></asp:Label>
        <asp:Label ID="lblCapacity" runat="server" Font-Bold="True" style="z-index: 1; left: 110px; top: 390px; position: absolute" Text="Capacity"></asp:Label>
        <asp:Label ID="lblColour" runat="server" Font-Bold="True" style="z-index: 1; left: 110px; top: 438px; position: absolute" Text="Colour"></asp:Label>
        <asp:Label ID="lbl128gb" runat="server" CssClass="auto-style3" Text="64gb"></asp:Label>
        <asp:Label ID="lblSpacegrey" runat="server" CssClass="auto-style4" Text="Blue"></asp:Label>
            <asp:Label ID="Label7" runat="server" CssClass="auto-style6" Font-Bold="False" Text="Samsung"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label runat="server" CssClass="auto-style5" Font-Bold="True" Text="Brand" ID="Label8"></asp:Label>
        </p>
        <asp:Button ID="btnContinueShopping" runat="server" OnClick="btnContinueShopping_Click" style="z-index: 1; left: 93px; top: 547px; position: absolute" Text="Continue Shopping" />
        <p>
            <asp:Button ID="btnAddToCart" runat="server" OnClick="btnAddToCart_Click" style="z-index: 1; left: 350px; top: 547px; position: absolute; width: 167px" Text="Add to cart" />
        </p>
    </form>
</body>
</html>
