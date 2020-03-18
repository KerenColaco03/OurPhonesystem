using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //
        //create an instance of clspyament
        clsPayment APayment = new clsPayment();
        //get the data from the session object
        if (Session["AnPayment"] != null)
        {
            APayment = (clsPayment)Session["AnPayment"];
        }
        //display the card holders name for this entry
        Response.Write(APayment.CardHoldersName);
        Response.Write(APayment.CardNo);
        Response.Write(APayment.CardExpiry);

        clsPayment SomePayment = new clsPayment();
        SomePayment.Find(3);

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

    }

    protected void btnBack_Click(object sender, EventArgs e)
    {

    }

    protected void txtCardHoldersName_TextChanged(object sender, EventArgs e)
    {

    }
}
