<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddSupplier.aspx.cs" Inherits="AddSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 12px;
            top: 96px;
            position: absolute;
            right: 860px;
            margin-left: 0px;
        }
        .auto-style2 {
            position: absolute;
            top: 268px;
            left: 38px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblAddSupplier" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Add Supplier"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name" CssClass="auto-style1"></asp:Label>
            <asp:Label ID="lblSupplierDate" runat="server" style="z-index: 1; left: 15px; top: 138px; position: absolute" Text="Supplier Date"></asp:Label>
            <asp:TextBox ID="txtSupplierDate" runat="server" style="z-index: 1; left: 117px; top: 136px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 19px; top: 231px; position: absolute" Text="OK" OnClick="btnOK_Click1" />
            <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 116px; top: 96px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style2"></asp:Label>
        <p>
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 123px; top: 227px; position: absolute" Text="Cancel" />
            <asp:Label ID="tblProductID" runat="server" style="z-index: 1; left: 19px; top: 185px; position: absolute" Text="ProductID"></asp:Label>
        </p>
        <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 119px; top: 184px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
