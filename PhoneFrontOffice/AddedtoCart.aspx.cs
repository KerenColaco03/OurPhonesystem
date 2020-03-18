using PhoneClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddedtoCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //
        //cretae a new instance of the clsOrderLine
        clsOrderLine AnOrderLine = new clsOrderLine();
        //get the data from the session object
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

    }

    protected void btnContinueShopping_Click(object sender, EventArgs e)
    {

    }
}