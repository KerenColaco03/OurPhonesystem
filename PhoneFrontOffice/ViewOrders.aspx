<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewOrders.aspx.cs" Inherits="ViewOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtDisplayOrder" runat="server" style="z-index: 1; left: 226px; top: 356px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblEnterCustomerID" runat="server" style="z-index: 1; left: 57px; top: 353px; position: absolute; width: 161px" Text="Please enter your customer ID"></asp:Label>
            <asp:ListBox ID="lstOrder" runat="server" OnSelectedIndexChanged="lstPayments_SelectedIndexChanged" style="z-index: 1; left: 117px; top: 90px; position: absolute; height: 225px; width: 267px"></asp:ListBox>
            <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 431px; top: 352px; position: absolute; height: 26px;" Text="Display All" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 124px; top: 527px; position: absolute" Text="[lblError]"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 434px; top: 394px; position: absolute; width: 89px" Text="Delete" />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Button" />
        </div>
    </form>
</body>
</html>
