using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;

public partial class PaymentDetails : System.Web.UI.Page
{
    //variable to store the priamry key with page level scope
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        
        {
            //add the nee record
            Add();
            //all done so redirect back to main page
            Response.Redirect("PaymentDisplay.aspx");
        }


    }
    void Add()
    {
        //create an intance of teh address book
        clsPaymentCollection PaymentBook = new clsPaymentCollection();
        //valdate th edta on the web form
        String Error = PaymentBook.ThisPayment.Valid(txtCardExpiry.Text, txtCardHoldersName.Text, txtCardNo.Text);
        //if the dtaa is OK then add it ot the object
        if (Error == "")
        {
            //gte the dtaa entered by the user
            PaymentBook.ThisPayment.CardExpiry = Convert.ToDateTime(txtCardExpiry.Text);
            PaymentBook.ThisPayment.CardHoldersName = txtCardHoldersName.Text;
            PaymentBook.ThisPayment.CardNo = Convert.ToInt32(txtCardNo.Text);
            //add the record
            PaymentBook.Add();
            Response.Redirect("PaymentDisplay.aspx");

        }
        else
        {
            //report an error
            lblError.Text = "there were problems with the data entered" + Error;

        }



    }
    


    protected void btnBack_Click(object sender, EventArgs e)
    {

    }
}