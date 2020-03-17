using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using PhoneTesting;

public partial class _Default : System.Web.UI.Page
{ //var to store the primary key value of the record to be deleted
    Int32 CustomerID;

    //event handler for the load event

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }
    void DeleteCustomer()
    {
        //create instance of clsCustomers called Addpage used to control addresses in the database
        clsCustomerCollection MyCustomerBook = new clsCustomerCollection();
        //find the record to be deleted
        MyCustomerBook.ThisCustomer.Find(CustomerID);
        //call the delete method of the object
        MyCustomerBook.Delete();
    }
    protected void ButtonYes_Click(object sender, EventArgs e)
    {
        DeleteCustomer();
        //redirect back to the main page
        Response.Redirect("Default.aspx");
    }

    protected void ButtonNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main pa ge
        Response.Redirect("Default.aspx");
    }


    protected void ButtonOK_Click(object sender, EventArgs e)
    {

    }
}
