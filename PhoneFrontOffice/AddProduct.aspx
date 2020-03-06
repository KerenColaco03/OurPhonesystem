<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddProduct.aspx.cs" Inherits="AddProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblBrand" runat="server" style="z-index: 1; left: 10px; top: 81px; position: absolute" Text="Brand"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblProductType" runat="server" style="z-index: 1; left: 6px; top: 125px; position: absolute" Text="Product Type"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblCapacity" runat="server" style="z-index: 1; left: 10px; top: 168px; position: absolute" Text="Capacity"></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" style="z-index: 1; left: 137px; top: 164px; position: absolute; right: 1259px" Text="64gb" />
            <asp:RadioButton ID="RadioButton2" runat="server" style="z-index: 1; left: 206px; top: 163px; position: absolute" Text="128gb" />
            <br />
            <br />
            <asp:Label ID="lblStockQuanity" runat="server" style="z-index: 1; left: 7px; top: 208px; position: absolute" Text="Product Quantity"></asp:Label>
            <asp:TextBox ID="txtProductQuanity" runat="server" style="z-index: 1; left: 133px; top: 206px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 12px; top: 253px; position: absolute" Text="Price"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 14px; top: 295px; position: absolute" Text="Colour"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 72px; top: 389px; position: absolute" Text="Add" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:TextBox ID="txtBrand" runat="server" style="z-index: 1; left: 129px; top: 78px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtProductType" runat="server" style="z-index: 1; left: 130px; top: 120px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 131px; top: 254px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlColour" runat="server" style="z-index: 1; left: 141px; top: 293px; position: absolute">
        </asp:DropDownList>
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 150px; top: 390px; position: absolute" Text="Back" />
        <asp:Label ID="lblAddProduct" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 27px; top: 20px; position: absolute" Text="Add Product"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 356px; position: absolute"></asp:Label>
    </form>
</body>
</html>
