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
        <asp:Label ID="lblCardHoldersnAME" runat="server" style="z-index: 1; left: 45px; top: 102px; position: absolute; right: 1009px;" Text="Card Holders Name"></asp:Label>
        <asp:Label ID="lblCardNo" runat="server" style="z-index: 1; left: 43px; top: 153px; position: absolute; bottom: 492px;" Text="Card No"></asp:Label>
        <asp:Label ID="lblCardExpiry" runat="server" style="z-index: 1; left: 45px; top: 202px; position: absolute" Text="Card Expiry"></asp:Label>
        <asp:TextBox ID="txtCardHoldersName" runat="server" style="z-index: 1; left: 177px; top: 110px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCardNo" runat="server" style="z-index: 1; left: 176px; top: 154px; position: absolute; height: 22px; margin-top: 0px;"></asp:TextBox>
        <asp:TextBox ID="txtCardExpiry" runat="server" style="z-index: 1; left: 178px; top: 206px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 151px; top: 284px; position: absolute; height: 29px; width: 45px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 85px; top: 384px; position: absolute; width: 198px" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 57px; top: 286px; position: absolute; right: 1186px; height: 29px;" Text="Back" OnClick="btnBack_Click" />
    </form>
</body>
</html>
