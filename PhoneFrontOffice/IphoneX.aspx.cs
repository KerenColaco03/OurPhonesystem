﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IphoneX : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("BrowseProducts.aspx");
    }

    protected void btnAddtoCart_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to inidcate this is a new record 
        Session["OrderLineID"] = 1;
        //redirect to the data entry page
        Response.Redirect("AddtoCart.aspx");
    }
}