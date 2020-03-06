using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaymentDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //clsPayment APayment = new clsPayment();
       // APayment.CardHoldersName = txtCardHoldersName.Text;
       // Session["APayment"] = APayment;
        ////APayment.CardNo = txtCardNo.Text;
       // APayment.CardExpiry = txtCardExpiry.Text;
        Response.Redirect("PaymentAdded.aspx");

        
    }
}