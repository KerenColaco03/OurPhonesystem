<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeletePayment.aspx.cs" Inherits="DeletePayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblPaymentdelete" runat="server" style="z-index: 1; left: 118px; top: 62px; position: absolute; height: 18px; width: 624px" Text="Are you sure you want to delete this Payment method?"></asp:Label>
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; top: 134px; position: absolute; width: 52px; left: 179px;" Text="No" />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 273px; top: 136px; position: absolute; width: 49px; right: 967px;" Text="Yes" />
        </div>
    </form>
</body>
</html>
