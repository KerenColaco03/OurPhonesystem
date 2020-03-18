<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditCart.aspx.cs" Inherits="EditCart" %>

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
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 264px; top: 468px; position: absolute; width: 138px; bottom: 170px;" Text="OK" OnClick="btnAdd_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 65px; top: 469px; position: absolute; height: 26px; width: 120px;" Text="Cancel" OnClick="btnContinueShopping_Click" />
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 177px; top: 356px; position: absolute"></asp:TextBox>
        <img class="auto-style1" src="Logo/iphone-11-pro-space-select-2019.jpg" /><asp:Label ID="lblError" runat="server" style="z-index: 1; left: 138px; top: 550px; position: absolute; width: 124px" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 91px; top: 356px; position: absolute" Text="Quantity"></asp:Label>
        <div>
        </div>
    </form>
</body>
</html>
