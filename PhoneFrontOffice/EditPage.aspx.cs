
using ClassLibrary;
using PhoneTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

public partial class EditPage : System.Web.UI.Page
{
    //var to store the address number
    Int32 CustomerID;


    protected void Page_Load(object sender, EventArgs e)
    {

        //get the address no from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        //if this is the first time the page has loaded
        if (IsPostBack == false)
        {
           
            //if we are not adding a new record
            if (CustomerID != -1)
            {
                //update the fields on the page with the data from the record
                DisplayCustomers();
            }
            else//this is a new record
            {
                //set the date to todays date
                txtDateAdded.Text = DateTime.Today.Date.ToString("dd/MM/yyyy"); ;
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("HomePage.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)

    {
        if (CustomerID == -1)
        {
            Add();
            //all done so redirect back to the main page
            Response.Redirect("AddPage.aspx");
        }
        else
        {
            //Update the record
            Update();
        }


    }




    //this function displays the data for an address on the web form
    void DisplayCustomers()
    {
        //create an instance of the addresses class
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record we want to display
        CustomerBook.ThisCustomer.Find(CustomerID);

        //diaplay the Firstname
        txtFirstname.Text = CustomerBook.ThisCustomer.Firstname;
        //diaplay the Lastname
        txtLastname.Text = CustomerBook.ThisCustomer.Lastname;
        //diaplay the Email
        txtEmail.Text = CustomerBook.ThisCustomer.Email;
        //display the house no
        txtHouseNo.Text = CustomerBook.ThisCustomer.HouseNo;
        //diaplay the street
        txtStreetname.Text = CustomerBook.ThisCustomer.Streetname;
        //display the County
        txtcounty.Text = CustomerBook.ThisCustomer.County;
        //display the post code
        txtPostCode.Text = CustomerBook.ThisCustomer.PostCode;
        //diaply the data added
        txtDateAdded.Text = CustomerBook.ThisCustomer.DateAdded.ToString("dd/MM/yyyy");
        //set the drop down list to display the country
        ddlCountry.SelectedValue = Convert.ToString(CustomerBook.ThisCustomer.Country);
        //display the active state
        chkActive.Checked = CustomerBook.ThisCustomer.Active;
    }
    void Add()
    {

        //create an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //use the objects validation method to test the data
        string Error = CustomerBook.ThisCustomer.Valid(txtFirstname.Text, txtLastname.Text, txtEmail.Text, txtHouseNo.Text, txtStreetname.Text, txtcounty.Text, txtPostCode.Text, txtDateAdded.Text);
        //if there is no error message
        if (Error == "")
        {



            CustomerBook.ThisCustomer.Firstname = txtFirstname.Text;

            CustomerBook.ThisCustomer.Lastname = txtLastname.Text;

            CustomerBook.ThisCustomer.Email = txtEmail.Text;

            //set the house number property of the object
            CustomerBook.ThisCustomer.HouseNo = txtHouseNo.Text;
            //set the street property
            CustomerBook.ThisCustomer.Streetname = txtStreetname.Text;
            //set the town property
            CustomerBook.ThisCustomer.County = txtcounty.Text;
            //set the post code property
            CustomerBook.ThisCustomer.PostCode = txtPostCode.Text;
            //set the data added
            CustomerBook.ThisCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //set the county code
            CustomerBook.ThisCustomer.Country = Convert.ToString(ddlCountry.SelectedValue);
            //set the active property
            CustomerBook.ThisCustomer.Active = chkActive.Checked;
            //invoke the add method
            CustomerBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("AddPage.aspx");


        }
        else//there are errors
        {
            //display the error message
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

   
    //function for updating records
    void Update()
    {

        //create an instance of the address class
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //validate the data on the web form
        string Error = CustomerBook.ThisCustomer.Valid(txtFirstname.Text, txtLastname.Text, txtEmail.Text, txtHouseNo.Text, txtStreetname.Text, txtcounty.Text, txtPostCode.Text, txtDateAdded.Text);
        //if there is no error message
        if (Error == "")
        {

            //find the record to update 
            CustomerBook.ThisCustomer.Find(CustomerID);
            //get the data entered by the user

            CustomerBook.ThisCustomer.Firstname = txtFirstname.Text;

            CustomerBook.ThisCustomer.Lastname = txtLastname.Text;

            CustomerBook.ThisCustomer.Email = txtEmail.Text;

            CustomerBook.ThisCustomer.HouseNo = txtHouseNo.Text;

            CustomerBook.ThisCustomer.Streetname = txtStreetname.Text;

            CustomerBook.ThisCustomer.County = txtcounty.Text;

            CustomerBook.ThisCustomer.PostCode = txtPostCode.Text;

            CustomerBook.ThisCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);

            CustomerBook.ThisCustomer.Country = Convert.ToString(ddlCountry.SelectedValue);

            CustomerBook.ThisCustomer.Active = chkActive.Checked;

            //update the record
            CustomerBook.Update();
            //all done so redirect back to main Page
            Response.Redirect("AddPage.aspx");
        }
        else//this is an existing record to update
        {
            lblError.Text = " There were problems with the data entered " + Error;
        }
    }
}
