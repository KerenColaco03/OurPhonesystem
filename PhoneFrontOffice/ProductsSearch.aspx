<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsSearch.aspx.cs" Inherits="ProductsSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstProducts" runat="server" style="z-index: 1; left: 18px; top: 18px; position: absolute; height: 258px; width: 541px" OnSelectedIndexChanged="lstProducts_SelectedIndexChanged"></asp:ListBox>
        </div>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 44px; top: 421px; position: absolute; height: 27px; width: 95px;" Text="Apply " OnClick="btnApply_Click" />
       
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 171px; top: 419px; position: absolute; height: 27px; width: 95px;" Text="Display All" OnClick="btnDisplayAll_Click" />
       
        <asp:TextBox ID="txtProductType" runat="server" style="z-index: 1; left: 33px; top: 339px; position: absolute; width: 221px"></asp:TextBox>
        <asp:Label ID="lblPleaseEnteraBrand" runat="server" style="z-index: 1; left: 36px; top: 308px; position: absolute" Text="Please Enter Product Type"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 31px; top: 502px; position: absolute; width: 71px; height: 28px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 119px; top: 501px; position: absolute; height: 28px; width: 78px;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 218px; top: 498px; position: absolute; height: 31px; width: 71px;" Text="Delete" OnClick="btnDelete_Click" />
       
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 31px; top: 564px; position: absolute"></asp:Label>
       
    </form>
</body>
</html>
