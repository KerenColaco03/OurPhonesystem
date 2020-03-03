<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 446px;
            width: 824px;
            text-align: left;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            width: 100%;
            height: 159px;
        }
        .auto-style4 {
            height: 39px;
        }
        .auto-style5 {
            height: 63px;
        }
        .auto-style6 {
            height: 39px;
            width: 571px;
        }
        .auto-style7 {
            width: 571px;
        }
        .auto-style8 {
            height: 63px;
            width: 571px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <div class="auto-style2">
                <br />
            </div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <table class="auto-style3">
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="lblPostCode" runat="server" Text="Please Enter a Post Code"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox1" runat="server" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="btnApply" runat="server" Text="Apply" Width="120px" />
                        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" Width="120px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="180px" />
                        <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="180px" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="180px" />
                    </td>
                    <td class="auto-style5"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
