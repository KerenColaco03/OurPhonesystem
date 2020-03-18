<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IphoneX.aspx.cs" Inherits="IphoneX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 325px;
            height: 312px;
        }
        .auto-style2 {
            position: absolute;
            top: 360px;
            left: 10px;
        }
        .auto-style5 {
            position: absolute;
            top: 491px;
            left: 108px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 404px;
            left: 210px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 443px;
            left: 212px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 488px;
            left: 212px;
            z-index: 1;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 70px; top: 47px; position: absolute; bottom: 787px;" Text="Iphone X"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <img alt="" class="auto-style1" src="Logo/iPhoneX-silver-1.jpg" /></p>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 387px; top: 174px; position: absolute" Text="£900"></asp:Label>
        <asp:Label ID="Label5" runat="server" CssClass="auto-style2" Font-Bold="True" style="z-index: 1; left: 335px; top: 173px; position: absolute; right: 1134px;" Text="Price:"></asp:Label>
        <asp:Label ID="lblCapacity" runat="server" Font-Bold="True" style="z-index: 1; left: 104px; top: 403px; position: absolute" Text="Capacity"></asp:Label>
        <asp:Label runat="server" CssClass="auto-style5" Font-Bold="True" Text="Brand" ID="Label8"></asp:Label>
        <asp:Label ID="lblColour" runat="server" Font-Bold="True" style="z-index: 1; left: 107px; top: 443px; position: absolute" Text="Colour"></asp:Label>
        <asp:Label ID="lbl128gb" runat="server" CssClass="auto-style3" Text="128gb"></asp:Label>
        <asp:Label ID="lblSpacegrey" runat="server" CssClass="auto-style4" Text="Silver"></asp:Label>
            <asp:Label ID="Label7" runat="server" CssClass="auto-style6" Font-Bold="False" Text="Apple"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 97px; top: 576px; position: absolute" Text="Continue Shoping" />
        <asp:Button ID="btnAddtoCart" runat="server" OnClick="btnAddtoCart_Click" style="z-index: 1; left: 301px; top: 573px; position: absolute; height: 28px; width: 158px" Text="Add to cart" />
    </form>
</body>
</html>
