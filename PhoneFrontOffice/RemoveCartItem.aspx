<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RemoveCartItem.aspx.cs" Inherits="RemoveCartItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Label ID="lblPaymentdelete" runat="server" style="z-index: 1; left: 118px; top: 62px; position: absolute; height: 18px; width: 624px; margin-bottom: 0px;" Text="Are you sure you want to remove this item?"></asp:Label>
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 253px; top: 132px; position: absolute; width: 52px; right: 984px; height: 25px;" Text="No" />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 169px; top: 130px; position: absolute; width: 49px; height: 26px; right: 829px;" Text="Yes" />
        <div>
        </div>
    </form>
</body>
</html>
