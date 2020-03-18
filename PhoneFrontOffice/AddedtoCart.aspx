<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddedtoCart.aspx.cs" Inherits="AddedtoCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .auto-style1 {
            width: 445px;
            height: 256px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Button ID="btnAddToCart" runat="server" style="z-index: 1; left: 264px; top: 468px; position: absolute; height: 26px; width: 99px; bottom: 170px;" Text="OK" OnClick="btnAdd_Click" />
        <asp:Button ID="btnContinueShopping" runat="server" style="z-index: 1; left: 70px; top: 468px; position: absolute; height: 26px; width: 113px; right: 1106px;" Text="Cancel" OnClick="btnContinueShopping_Click" />
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 173px; top: 356px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 78px; top: 358px; position: absolute; bottom: 273px" Text="Quantity"></asp:Label>
        <img class="auto-style1" src="Logo/iphone-11-pro-space-select-2019.jpg" /></div>
    </form>
</body>
</html>
