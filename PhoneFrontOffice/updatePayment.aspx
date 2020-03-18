<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatePayment.aspx.cs" Inherits="updatePayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
        <asp:Label ID="lblCardExpiry" runat="server" style="z-index: 1; left: 49px; top: 203px; position: absolute" Text="Card Expiry"></asp:Label>
        <asp:TextBox ID="txtCardHoldersName" runat="server" style="z-index: 1; left: 173px; top: 109px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCardNo" runat="server" style="z-index: 1; left: 170px; top: 154px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCardExpiry" runat="server" style="z-index: 1; left: 167px; top: 209px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 162px; top: 280px; position: absolute; width: 55px; height: 26px;" Text="OK" OnClick="btnAdd_Click" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 85px; top: 384px; position: absolute; width: 198px" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 55px; top: 283px; position: absolute; right: 1029px" Text="Cancel" OnClick="btnBack_Click" />
            <asp:Label ID="lblCardNo" runat="server" style="z-index: 1; left: 51px; top: 155px; position: absolute" Text="Card No"></asp:Label>
            <asp:Label ID="lblCardHoldersName" runat="server" style="z-index: 1; left: 48px; top: 105px; position: absolute" Text="Card Holders Name"></asp:Label>
        </p>
    </form>
</body>
</html>
