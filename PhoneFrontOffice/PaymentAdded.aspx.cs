using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of clspyament
        //clsPayment APayment = new clsPayment();
        //get the data from the session object
        //APayment = (clsPayment)Session["APayment"];
        //display the card holders name for this entry
       // Response.Write(APayment.CardHoldersName);
       // Response.Write(APayment.CardNo);
       // Response.Write(APayment.CardExpiry);
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

    }
}