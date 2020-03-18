<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddtoCart.aspx.cs" Inherits="AddtoCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 445px;
            height: 256px;
        }
        #form1 {
            height: 306px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 1816px; top: 688px; position: absolute; width: 144px; bottom: -50px;" Text="OK" OnClick="btnAdd_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 90px; top: 468px; position: absolute; height: 26px; width: 120px;" Text="Cancel" OnClick="btnContinueShopping_Click" />
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 81px; top: 355px; position: absolute; bottom: 480px" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 177px; top: 356px; position: absolute"></asp:TextBox>
        <img class="auto-style1" src="Logo/iphone-11-pro-space-select-2019.jpg" /><div>
            <p>
                <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 138px; top: 550px; position: absolute; width: 124px" Text="[lblError]"></asp:Label>
            </p>
        </div>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnAddToCart" runat="server" style="z-index: 1; left: 259px; top: 467px; position: absolute; height: 27px; width: 110px; " Text="OK" OnClick="btnAdd_Click" />
        </p>
    </form>
</body>
</html>
