using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditPage : System.Web.UI.Page
{
    //var to store the address number
    Int32 CustomerID;

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("Default.aspx");
    }
}


protected void Page_Load(object sender, EventArgs e)
    {
    //get the address no from the session object
    CustomerID = Convert.ToInt32(Session["CustomerID"]);
        //if this is the first time the page has loaded
        if (IsPostBack == false)
        {
            //populate the counties drop down
            DisplayCounties();
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
}

    protected void btnOK_Click(object sender, EventArgs e)
    {
    //var to store any error messages
    string ErrorMsg;
    //create an instance of the address class
    clsCustomerCollection CustomerBook = new clsCustomerCollection();
    //use the objects validation method to test the data
    ErrorMsg = CustomerBook.ThisCustomer.Valid(txtFirstname.Text, txtLastname.Text, txtEmail.Text, txtHouseNo.Text, txtStreetname.Text, txtcounty.Text, txtPostCode.Text, txtDateAdded.Text);
    //if there is no error message
    if (ErrorMsg == "")
    {
        //if we are adding a new record
        if (CustomerID == -1)
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
            CustomerBook.ThisCustomer.CountryCode = Convert.ToInt32(ddlCountry.SelectedValue);
            //set the active property
            CustomerBook.ThisCustomer.Active = chkActive.Checked;
            //invoke the add method
            CustomerBook.Add();
        }
        else//this is an existing record to update
        {
            //find the record to be updated
            CustomerBook.ThisCustomer.Find(CustomerID);
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
            CustomerBook.ThisCustomer.CountryCode = Convert.ToInt32(ddlCountry.SelectedValue);
            //set the active property
            CustomerBook.ThisCustomer.Active = chkActive.Checked;
            //invoke the add method
            CustomerBook.Update();
        }
        //all done so redirect back to the main page
        Response.Redirect("Default.aspx");
    }
    else//there are errors
    {
        //display the error message
        lblError.Text = ErrorMsg;
    }
}

//this function is used to populate the counties drop down list
Int32 DisplayCounties()
{
    //create an instance of the county class
    clsCountyCollection Counties = new clsCountyCollection();
    //var to store the county number primary key
    string CountyNo;
    //var to store the name of the county
    string County;
    //var to store the index for the loop
    Int32 Index = 0;
    //while the index is less that the number of records to process
    while (Index < Counties.Count)
    {
        //get the county number from the database
        CountyNo = Convert.ToString(Counties.AllCounties[Index].CountyNo);
        //get teh county name from the database
        County = Counties.AllCounties[Index].County;
        //set up the new row to be added to the list
        ListItem NewCounty = new ListItem(County, CountyNo);
        //add the new row to the list
        ddlCounty.Items.Add(NewCounty);
        //increment the index to the next record
        Index++;
    }
    //return the number of records found
    return Counties.Count;
}

//this function displays the data for an address on the web form
void DisplayCustomer()
{
    //create an instance of the addresses class
    clsCustomerCollection MyCustomerBook = new clsCustomerCollection();
    //find the record we want to display
    MyCustomerBook.ThisCustomer.Find(CustomerID);

    txtFirstname.Text = MyCustomerBook.ThisCustomer.Firstname;
    txtLastname.Text = MyCustomerBook.ThisCustomer.Lastname;
    txtEmail.Text = MyCustomerBook.ThisCustomer.Email;
    //display the house no
    txtHouseNo.Text = MyCustomerBook.ThisCustomer.HouseNo;
    //diaplay the street
    txtStreetname.Text = MyCustomerBook.ThisCustomer.Streename;
    //display the town
    txtCounty.Text = MyCustomerBook.ThisCustomer.County;
    //display the post code
    txtPostCode.Text = MyCustomerBook.ThisCustomer.PostCode;
    //diaply the data added
    txtDateAdded.Text = MyCustomerBook.ThisCustomer.DateAdded.ToString("dd/MM/yyyy");
    //set the drop down list to display the county
    ddlCountry.SelectedValue = Convert.ToString(MyCustomerBook.ThisCustomer.CountryCode);
    //display the active state
    chkActive.Checked = MyCustomerBook.ThisCustomer.Active;
}
}
    }
}