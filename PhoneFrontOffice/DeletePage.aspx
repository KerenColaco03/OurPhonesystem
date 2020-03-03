<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeletePage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 143px;
            width: 806px;
        }
        .auto-style2 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <table class="auto-style2">
                <tr>
                    <td>
                        <asp:Label ID="lblCustomerID" runat="server" Text="Are you sure you want to delete this address?"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" Width="100px" />
                        <asp:Button ID="Button2" runat="server" Text="Button" Width="100px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
