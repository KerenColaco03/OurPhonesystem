<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BrowseProducts.aspx.cs" Inherits="BrowseProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl1050" runat="server" style="z-index: 1; left: 259px; top: 75px; position: absolute; bottom: 763px" Text="£1,050"></asp:Label>
            <asp:Label ID="lblSamsungGalaxyS9" runat="server" style="z-index: 1; left: 13px; top: 132px; position: absolute; right: 821px;" Text="Samsung Galaxy S9"></asp:Label>
            <asp:Label ID="lbl900" runat="server" style="z-index: 1; left: 262px; top: 184px; position: absolute; right: 1216px;" Text="£900"></asp:Label>
            <br />
        </div>
        <p>
            <asp:Button ID="btnDetails" runat="server" style="z-index: 1; left: 452px; top: 72px; position: absolute" Text="Details" OnClick="btnDetails_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnDetail0" runat="server" style="z-index: 1; left: 453px; top: 130px; position: absolute; margin-bottom: 0px" Text="Details" OnClick="btnDetail0_Click" />
        </p>
        <p>
            <asp:Label ID="lblIphone11Pro0" runat="server" style="z-index: 1; left: 17px; top: 78px; position: absolute" Text="Iphone 11 Pro"></asp:Label>
            <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 454px; top: 187px; position: absolute" Text="Details" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Label ID="lblBrowseProducts" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 19px; top: 21px; position: absolute" Text="Browse Products"></asp:Label>
            <asp:Label ID="lblIphoneX" runat="server" style="z-index: 1; left: 16px; top: 184px; position: absolute" Text="Iphone X"></asp:Label>
            </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lbl1051" runat="server" style="z-index: 1; left: 266px; top: 132px; position: absolute; right: 708px;" Text="£800"></asp:Label>
            </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
