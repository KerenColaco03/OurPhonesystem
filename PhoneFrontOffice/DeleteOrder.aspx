<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrder.aspx.cs" Inherits="DeleteOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Label ID="lblPaymentdelete" runat="server" style="z-index: 1; left: 111px; top: 86px; position: absolute; height: 53px; width: 624px; margin-bottom: 0px;" Text="Are you sure you want to remove this Order?"></asp:Label>
        <div>
            <asp:Button ID="btnNo0" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 254px; top: 132px; position: absolute; width: 52px; right: 325px;" Text="No" />
            <asp:Button ID="btnYes0" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 169px; top: 130px; position: absolute; width: 49px; right: 264px;" Text="Yes" />
        </div>
    </form>
</body>
</html>
