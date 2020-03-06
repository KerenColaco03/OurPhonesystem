<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentDetails.aspx.cs" Inherits="PaymentDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCardHoldersnAME" runat="server" style="z-index: 1; left: 44px; top: 102px; position: absolute; right: 1137px;" Text="Card Holders Name"></asp:Label>
        <asp:Label ID="lblCardNo" runat="server" style="z-index: 1; left: 43px; top: 153px; position: absolute" Text="Card No"></asp:Label>
        <asp:Label ID="lblCardExpiry" runat="server" style="z-index: 1; left: 47px; top: 202px; position: absolute" Text="Card Expiry"></asp:Label>
        <asp:TextBox ID="txtCardHoldersName" runat="server" style="z-index: 1; left: 173px; top: 109px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCardNo" runat="server" style="z-index: 1; left: 170px; top: 154px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCardExpiry" runat="server" style="z-index: 1; left: 167px; top: 209px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 151px; top: 284px; position: absolute; height: 29px; " Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 55px; top: 283px; position: absolute; right: 1188px" Text="Back" />
    </form>
</body>
</html>
