<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 250px;
            height: 250px;
        }
        .auto-style2 {
            width: 100%;
        }
  .content p {
    margin-bottom: 20px; }
  p.sp-intro-text, .sp-intro-text p {
  font-family: 'Neue Helvetica W05', Helvetica, Arial, sans-serif !important;
  font-weight: 400;
  font-style: normal;
  line-height: 1.5;
  font-size: 20px;
  letter-spacing: -0.1px;
  color: #404041;
  opacity: 1; }

.content p {
  opacity: 1;
  color: #404041;
  font-family: 'Neue Helvetica W05', Helvetica, Arial, sans-serif !important;
  font-weight: 400;
  font-style: normal;
  font-size: 1.6rem;
  line-height: 28px;
  letter-spacing: normal;
  margin-bottom: 30px;
  text-shadow: 1px 1px 1px rgba(0, 0, 0, 0.004);
  text-rendering: optimizeLegibility !important;
  -webkit-font-smoothing: antialiased !important;
  -moz-osx-font-smoothing: grayscale; }

.our_business_home p {
  font-size: 20px;
  font-weight: normal;
  font-style: normal;
  font-stretch: normal;
  line-height: 1.7;
  letter-spacing: normal;
  color: #666666; }

.content p {
  margin: 0 0 40px;
  font-size: 1.6rem;
  line-height: 20px; }

p {
  margin: 0 0 10px; }

  p,
  h2,
  h3 {
    orphans: 3;
    widows: 3; }
  p{margin:0 0 10px}h2,h3,p{orphans:3;widows:3}
* {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }

  *,
  *:before,
  *:after {
    background: transparent !important;
    color: #000 !important;
    box-shadow: none !important;
    text-shadow: none !important; }
  *{-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}*,:after,:before{color:#000!important;text-shadow:none!important;background:0 0!important;-webkit-box-shadow:none!important;box-shadow:none!important}</style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 583px">
            <img class="auto-style1" src="Pictures/PHONES4.png" /><asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Phones4less LTD"></asp:Label>
            <br />
            <br />
            <table class="auto-style2">
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register" />
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Login" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;<p class="sp-intro-text">
                        Phone4Less LTD is a leading multinational consumer electrical and mobile retailer and service company. We are the market leader in the UK &amp; Ireland, throughout the Nordics and in Greece.</p>
                        <p class="sp-intro-text">
                            We offer a full range of services and support, we make it easy for our customers to discover, choose and enjoy the right technology for them, throughout the life of the product.</p>
                        <p class="sp-intro-text">
                            Because of our strengths, especially those that come from our scale, we are better placed than anyone to help customers to do all of that.</p>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
