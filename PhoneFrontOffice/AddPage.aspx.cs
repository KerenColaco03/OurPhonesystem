using PhoneTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class AddPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear any existing error messages
        lblError.Text = "";
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            //populate the list and display the number of records found
            lblError.Text = DisplayCustomers("") + " records in the database";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("EditPage.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("EditPage.aspx");

        
    }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayCustomers(txtPostCode.Text);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayCustomers("");
        //display the number of records found
        lblError.Text = RecordCount + " records in the database";
        //clear the post code filter text box
        txtPostCode.Text = "";
    }
    Int32 DisplayCustomers(string PostCodeFilter)
    {
        ///this function accepts one parameter - the post code to filter the list on
        ///it populates the list box with data from the middle layer class
        ///it returns a single value, the number of records found

        //create a new instance of the clsAddress
        clsCustomerCollection MyCustomerBook = new clsCustomerCollection();
        //var to store the count of records
        Int32 RecordCount;
        string Firstname;

        string Lastname;

        string Email;

        //var to store the house no
        string HouseNo;
        //var to store the street name
        string Streetname;
        //var to store the post code
        string PostCode;
        //var to store the primary key value
        string CustomerID;
        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        lstCustomers.Items.Clear();
        //call the filter by post code method
        MyCustomerBook.ReportByPostCode(PostCodeFilter);
        //get the count of records found
        RecordCount = MyCustomerBook.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            Firstname = Convert.ToString(MyCustomerBook.CustomerList[Index].Firstname);
            Lastname = Convert.ToString(MyCustomerBook.CustomerList[Index].Lastname);
            Email = Convert.ToString(MyCustomerBook.CustomerList[Index].Email);
            HouseNo = Convert.ToString(MyCustomerBook.CustomerList[Index].HouseNo);
            //get the street from the query results
            Streetname = Convert.ToString(MyCustomerBook.CustomerList[Index].Streetname);
            //get the post code from the query results
            PostCode = Convert.ToString(MyCustomerBook.CustomerList[Index].PostCode);
            //get the address no from the query results
            CustomerID = Convert.ToString(MyCustomerBook.CustomerList[Index].CustomerID);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(Firstname + " " + Lastname + " " + Email + " " + HouseNo + " " + Streetname + " " + PostCode, CustomerID);
            //add the new item to the list
            lstCustomers.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

}