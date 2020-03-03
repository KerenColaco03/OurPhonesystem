<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 170px;
        }
        .auto-style3 {
            text-align: right;
            width: 266px;
        }
        .auto-style4 {
            width: 66px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">FirstName:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxFN" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxFN" ErrorMessage="Firstname is required." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">LastName:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxLN" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxLN" ErrorMessage="Lastname is required." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email is required." ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="You must enter a valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Username:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxUN" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxUN" ErrorMessage="Username is required." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Password:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="Password is required." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Confirm Password:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxConfirmPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxConfirmPass" ErrorMessage="Confirm Password is required." ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBoxConfirmPass" ErrorMessage="Both Password must match." ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Country:</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownListCountry" runat="server" Width="180px">
                        <asp:ListItem>Select Country</asp:ListItem>
                        <asp:ListItem>Ghana</asp:ListItem>
                        <asp:ListItem>United Kingdom</asp:ListItem>
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>Kenya</asp:ListItem>
                        <asp:ListItem>Brazil</asp:ListItem>
                        <asp:ListItem>Nigeria</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownListCountry" ErrorMessage="Select a Country" ForeColor="Red" InitialValue="Select Country"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Postcode:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxPost" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBoxPost" ErrorMessage="Postcode is required." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">StreetName:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxStreet" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBoxStreet" ErrorMessage="Street name is required." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">CountyNo:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxCounty" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBoxCounty" ErrorMessage="CountyNo is required." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">HouseNo:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxHouseNo" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextBoxHouseNo" ErrorMessage="HouseNo is required." ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit" />
                    <input id="Reset1" class="auto-style4" type="reset" value="reset" /></td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PhonesConnectionString %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>
    </form>
</body>
</html>
