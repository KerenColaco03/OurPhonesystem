using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;
public partial class updatePayment : System.Web.UI.Page
{
    Int32 PaymentID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //GET THE NUMBER OD pYAMENT id TO BE PROCESSED
        PaymentID = Convert.ToInt32(Session["PaymentID"]);
        if (IsPostBack == false)
        {
            //popuate the list of payments
            DisplayPayments();
            //if this not a new record
            if (PaymentID != -1)
            {
                //diaply the current data for the record
                DisplayPayments();
            }
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if(PaymentID == -1)
        {
            //AddedControl the new reocrd
                Add();
        }
        else
        {
            ////updatd the reocrd
           Update();          
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
            Response.Redirect("PaymentDisplay");

        }
        else
        {
            //report an error
            lblError.Text = "there were problems with the data entered" + Error;

        }



    }
    //fucntion for updating records
    void Update()
    {
        //create an intance of the Payment Book
        PhoneClasses.clsPaymentCollection PaymentBook = new PhoneClasses.clsPaymentCollection();
        //validate the data on the web form
        String Error = PaymentBook.ThisPayment.Valid(txtCardExpiry.Text, txtCardNo.Text, txtCardHoldersName.Text);
        //if the dta is ok then ad it to the object
        if (Error =="")
        {
            //find the record to update
            PaymentBook.ThisPayment.Find(PaymentID);
            //get the dta entered by the user
            PaymentBook.ThisPayment.CardExpiry = Convert.ToDateTime(txtCardExpiry.Text);
;           PaymentBook.ThisPayment.CardNo = Convert.ToInt32(txtCardNo.Text);
            PaymentBook.ThisPayment.CardHoldersName = txtCardHoldersName.Text;
            //update the record
            PaymentBook.Update();
            //all done so redirect to the main page 
            Response.Redirect("PaymentDisplay.aspx");

        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;

        }


    }
    void DisplayPayments ()
    {
        //create an insatnce of the apaymentbook
        clsPaymentCollection PaymentBook = new clsPaymentCollection();
        //find the reocrd to upate
        PaymentBook.ThisPayment.Find(PaymentID);
        //diaplay the dtaa for this record
        txtCardExpiry.Text = PaymentBook.ThisPayment.CardExpiry.ToString();
        txtCardHoldersName.Text = PaymentBook.ThisPayment.CardNo.ToString();
        txtCardHoldersName.Text = PaymentBook.ThisPayment.CardHoldersName;
        
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {

    }
}