<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DisplayBasket.aspx.cs" Inherits="DisplayBasket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 170px; top: 283px; position: absolute; width: 131px" Text="Continue Shopping" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 168px; top: 324px; position: absolute; height: 26px; width: 105px;" Text="Checkout" />
        <asp:Button ID="btnRemoveItem" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 682px; top: 117px; position: absolute" Text="remove item" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 158px; top: 391px; position: absolute; width: 99px" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnEditCart" runat="server" OnClick="Button5_Click" style="z-index: 1; left: 683px; top: 163px; position: absolute; width: 101px; height: 26px;" Text="Edit Cart" />
        <asp:ListBox ID="lstCart" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="z-index: 1; left: 65px; top: 72px; position: absolute; height: 165px; width: 577px"></asp:ListBox>
        <div>
        </div>
    </form>
</body>
</html>
