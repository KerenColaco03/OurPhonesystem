<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditPage.aspx.cs" Inherits="EditPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 307px;
        }
        .auto-style2 {
            width: 206px;
        }
        .auto-style3 {
            width: 206px;
            height: 27px;
        }
        .auto-style4 {
            height: 27px;
        }
        .auto-style5 {
            width: 206px;
            text-align: right;
        }
    </style>
</head>
<body style="height: 369px; width: 854px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Profile Page"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblFirstname" runat="server" Text="Firstname"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblLastname" runat="server" Text="Lastname"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlCountry" runat="server">
                            <asp:ListItem>Select a Country</asp:ListItem>
                            <asp:ListItem>Nigeria</asp:ListItem>
                            <asp:ListItem>France</asp:ListItem>
                            <asp:ListItem>UK</asp:ListItem>
                            <asp:ListItem>Germany</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblStreetname" runat="server" Text="Streetname"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtStreetname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblPostcode" runat="server" Text="Postcode"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblHouseNo" runat="server" Text="HouseNo"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtHouseNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        County</td>
                    <td>
                        <asp:TextBox ID="txtcounty" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        Date Added</td>
                    <td>
                        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblError" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" Width="64px" />
                    </td>
                    <td>
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                    </td>
                </tr>
            </table>
        </p>
    </form>
</body>
</html>
