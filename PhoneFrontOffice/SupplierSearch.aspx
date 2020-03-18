<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierSearch.aspx.cs" Inherits="SupplierSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:ListBox ID="lstSuppliers" runat="server" style="z-index: 1; left: 18px; top: 18px; position: absolute; height: 258px; width: 541px"></asp:ListBox>
        <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 303px; top: 331px; position: absolute; height: 27px; width: 95px;" Text="Search" />
       
        <asp:Button ID="btnShowAll" runat="server" style="z-index: 1; left: 308px; top: 391px; position: absolute; height: 27px; width: 95px;" Text="Show All" />
       
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 33px; top: 339px; position: absolute; width: 221px"></asp:TextBox>
        <asp:Label ID="lblPleaseEnterSupplierName" runat="server" style="z-index: 1; left: 36px; top: 308px; position: absolute" Text="Please Enter Supplier Name"></asp:Label>
        <asp:Button ID="btnAddSupplier" runat="server" style="z-index: 1; left: 29px; top: 502px; position: absolute; width: 95px; height: 28px;" Text="Add Supplier" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEditSupplier" runat="server" style="z-index: 1; left: 152px; top: 501px; position: absolute; height: 28px; width: 118px; right: 984px;" Text="Edit Supplier" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDeleteSupplier" runat="server" style="z-index: 1; left: 310px; top: 498px; position: absolute; height: 31px; width: 121px;" Text="Delete Supplier" OnClick="btnDelete_Click" />
       
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 31px; top: 564px; position: absolute"></asp:Label>
       
        <div>
        </div>
    </form>
</body>
</html>
