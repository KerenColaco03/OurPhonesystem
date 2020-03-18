using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BrowseProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDetails_Click(object sender, EventArgs e)
    {
        Response.Redirect("Iphone11Pro.aspx");
    }

    protected void btnDetail0_Click(object sender, EventArgs e)
    {
        Response.Redirect("SamsungGalaxyS9.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("IphoneX.aspx");
    }
}