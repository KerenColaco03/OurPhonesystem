using PhoneClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeletePayment : System.Web.UI.Page
{
    Int32 PaymentID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //
        //get the number of thepayment to be delted from the session object
        PaymentID = Convert.ToInt32(Session["PaymentID"]);
    }
    void DeletePayments()
    {
        //fucntion to delte the selected record
        //create a new insatcne of the payment book
        clsPaymentCollection PaymentBook = new clsPaymentCollection();
        //find the reocrd to delete
        PaymentBook.ThisPayment.Find(PaymentID);
        //delete the record
        PaymentBook.Delete();
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentDisplay.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeletePayments();
        //redirect back to the main page
        Response.Redirect("PaymentDisplay.aspx");
    }
    
}
