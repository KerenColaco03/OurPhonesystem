<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteProduct.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Are you sure you want to delete this product?"></asp:Label>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 35px; top: 51px; position: absolute; height: 26px; width: 60px" Text="Yes" />
        </div>
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 142px; top: 51px; position: absolute; width: 59px" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
