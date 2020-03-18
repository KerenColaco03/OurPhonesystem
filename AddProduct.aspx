﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddProduct.aspx.cs" Inherits="AddProduct" %>

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
            <asp:Label ID="lblProductType" runat="server" style="z-index: 1; left: 14px; top: 322px; position: absolute" Text="Product Type"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblCapacity" runat="server" style="z-index: 1; left: 11px; top: 127px; position: absolute" Text="Capacity"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblProductQuanity" runat="server" style="z-index: 1; left: 11px; top: 279px; position: absolute" Text="Product Quantity"></asp:Label>
            <asp:TextBox ID="txtProductQuantity" runat="server" style="z-index: 1; left: 129px; top: 277px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 14px; top: 227px; position: absolute" Text="Price"></asp:Label>
            <asp:DropDownList ID="ddlCapacity" runat="server" style="z-index: 1; left: 133px; top: 127px; position: absolute">
                <asp:ListItem Value="32gb"></asp:ListItem>
                <asp:ListItem Value="64gb"></asp:ListItem>
                <asp:ListItem Value="128gb"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 13px; top: 177px; position: absolute" Text="Colour"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 72px; top: 389px; position: absolute; height: 26px;" Text="Add" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:TextBox ID="txtBrand" runat="server" style="z-index: 1; left: 129px; top: 78px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtProductType" runat="server" style="z-index: 1; left: 136px; top: 323px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 124px; top: 227px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlColour" runat="server" style="z-index: 1; left: 133px; top: 175px; position: absolute">
            <asp:ListItem Value="Black"></asp:ListItem>
            <asp:ListItem Value="Space Grey"></asp:ListItem>
            <asp:ListItem Value="Blue"></asp:ListItem>
            <asp:ListItem Value="Red"></asp:ListItem>
            <asp:ListItem Value="Silver"></asp:ListItem>
            <asp:ListItem Value="Gold"></asp:ListItem>
            <asp:ListItem Value="Midnight Green"></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 150px; top: 390px; position: absolute" Text="Back" OnClick="btnBack_Click" />
        <asp:Label ID="lblAddProduct" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 27px; top: 20px; position: absolute" Text="Add Product"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 356px; position: absolute"></asp:Label>
    </form>
</body>
</html>