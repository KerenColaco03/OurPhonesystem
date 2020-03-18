<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EnterOrderdetails.aspx.cs" Inherits="EnterOrderdetails" %>

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
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 300px; top: 221px; position: absolute; width: 56px; right: 933px; height: 20px;" Text="OK" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 114px; top: 280px; position: absolute" Text="[lblError]"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 143px; top: 164px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 142px; top: 112px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 141px; top: 214px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label runat="server" style="z-index: 1; left: 64px; top: 163px; position: absolute; bottom: 482px;" Text="Order Date"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 64px; top: 104px; position: absolute" Text="CustomerID"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 66px; top: 59px; position: absolute; width: 293px" Text="Please confirm your details"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 66px; top: 214px; position: absolute" Text="Total Price"></asp:Label>
    </form>
</body>
</html>
