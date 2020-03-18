<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductAdded.aspx.cs" Inherits="ProductAdded" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblBrand" runat="server" style="z-index: 1; left: 10px; top: 81px; position: absolute" Text="Brand"></asp:Label>
            <asp:Label ID="lblProductType" runat="server" style="z-index: 1; left: 6px; top: 125px; position: absolute" Text="Product Type"></asp:Label>
            <asp:Label ID="lblCapacity" runat="server" style="z-index: 1; left: 10px; top: 168px; position: absolute" Text="Capacity"></asp:Label>
            <asp:Label ID="lblProductQuanity" runat="server" style="z-index: 1; left: 7px; top: 208px; position: absolute" Text="Product Quantity"></asp:Label>
            <asp:TextBox ID="txtStockQuanity" runat="server" style="z-index: 1; left: 133px; top: 206px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 12px; top: 253px; position: absolute" Text="Price"></asp:Label>
            <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 13px; top: 295px; position: absolute" Text="Colour"></asp:Label>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 72px; top: 389px; position: absolute" Text="Add" />
            <asp:TextBox ID="txtBrand" runat="server" style="z-index: 1; left: 129px; top: 78px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtProductType" runat="server" style="z-index: 1; left: 130px; top: 120px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 131px; top: 254px; position: absolute"></asp:TextBox>
            <asp:DropDownList ID="ddlColour" runat="server" style="z-index: 1; left: 141px; top: 293px; position: absolute">
            </asp:DropDownList>
            <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 150px; top: 390px; position: absolute" Text="Back" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 356px; position: absolute"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 14px; top: 33px; position: absolute" Text="Product Added "></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 29px; top: 457px; position: absolute" Text="Product has been added succesfully"></asp:Label>
        <asp:DropDownList ID="ddlCapacity" runat="server" style="z-index: 1; left: 134px; top: 167px; position: absolute">
        </asp:DropDownList>
    </form>
</body>
</html>
