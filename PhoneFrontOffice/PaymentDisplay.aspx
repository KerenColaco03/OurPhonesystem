<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentDisplay.aspx.cs" Inherits="PaymentDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 97px; top: 440px; position: absolute; width: 58px; height: 23px;" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; top: 438px; position: absolute; width: 61px; left: 251px; height: 25px; margin-top: 0px;" Text="Delete" OnClick="btnDelete_Click" />
            <asp:TextBox ID="txtDisplayPayment" runat="server" style="z-index: 1; left: 243px; top: 356px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblEnterCustomerID" runat="server" style="z-index: 1; left: 57px; top: 353px; position: absolute; width: 161px" Text="Please enter your customer ID"></asp:Label>
            <asp:ListBox ID="lstPayments" runat="server" OnSelectedIndexChanged="lstPayments_SelectedIndexChanged" style="z-index: 1; left: 117px; top: 90px; position: absolute; height: 225px; width: 267px"></asp:ListBox>
            <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 431px; top: 352px; position: absolute" Text="Display All" />
        </div>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 189px; top: 438px; position: absolute; right: 1142px" Text="Edit" OnClick="btnEdit_Click" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 124px; top: 527px; position: absolute" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
