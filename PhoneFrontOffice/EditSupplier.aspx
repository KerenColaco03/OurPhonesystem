<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditSupplier.aspx.cs" Inherits="EditSupplier" %>

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
            right: 1037px;
        }
        .auto-style2 {
            position: absolute;
            top: 257px;
            left: 38px;
            z-index: 1;
            width: 69px;
        }
        .auto-style3 {
            position: absolute;
            top: 255px;
            left: 198px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 325px;
            left: 31px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Label ID="lblAddSupplier" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Edit Supplier"></asp:Label>
            <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name" CssClass="auto-style1"></asp:Label>
            <asp:Label ID="lblSupplierDate" runat="server" style="z-index: 1; left: 15px; top: 138px; position: absolute" Text="Supplier Date"></asp:Label>
            <asp:TextBox ID="txtSupplierDate" runat="server" style="z-index: 1; left: 117px; top: 136px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 116px; top: 96px; position: absolute"></asp:TextBox>
        <div>
        </div>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style3" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            <asp:Button ID="btnOK" runat="server" CssClass="auto-style2" Text="OK" OnClick="btnOK_Click" />
        </p>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style4"></asp:Label>
            <asp:Label ID="tblProductID" runat="server" style="z-index: 1; left: 19px; top: 185px; position: absolute" Text="ProductID"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 119px; top: 184px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
