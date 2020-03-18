using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaymentDisplay : System.Web.UI.Page
{
    //this function handles the load veent for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if yhid id the first time page is dislayed
        if (IsPostBack == false)
        {
            //
            //update the list box
            DisplayPayments();

        }
        void DisplayPayments()
        {
            //create an instance of the collection
            PhoneClasses.clsPaymentCollection Payments = new PhoneClasses.clsPaymentCollection();
            //set the data 
            lstPayments.DataSource = Payments.PaymentList;
            lstPayments.DataValueField = "PaymentID";
            lstPayments.DataTextField = "CardNo";
            lstPayments.DataBind();
        }
    }

    //event handlet for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object indicate this is an enew record
        Session["PaymentID"] = -1;
        //redirect to the data entry oage
        Response.Redirect("PaymentDetails.aspx");

    }
    //function for addinf 
    protected void lstPayments_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to e delted
        Int32 PaymentID;
        //if a record had been slected fromt he list
        if (lstPayments.SelectedIndex != -1)
        {
            //gte th eprimary key value of te rcord to dlete
            PaymentID = Convert.ToInt32(lstPayments.SelectedValue);
            //store the data in the session object
            Session["PaymentID"] = PaymentID;
            //REDIRECT TO DEETE PAGE
            Response.Redirect("DeletePayment.aspx");


        }
        else
        {
            //if no record has been selected
            lblError.Text = "please select a rcord to delete from the list";

        }

                
        }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to toe the primarykey vaue of he record to bve edited
        Int32 PaymentID;
        //if a record hads been sleected from the list
        if(lstPayments.SelectedIndex != -1)
        {
            //get the primary key value of the record ot edit
            PaymentID = Convert.ToInt32(lstPayments.SelectedValue);
            //stiore the dtaa i the session object
            Session["PaymentID"] = PaymentID;
            //rdirect to the edit page
            Response.Redirect("updatePayment.aspx");
        }
        else
        {
            //display an error 
            lblError.Text = "please slect a rcord to delete from the list";
        }
    }
}


