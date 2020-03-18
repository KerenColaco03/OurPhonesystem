using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SupplierSearch : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is dispalyed
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if (IsPostBack == false)
        {
            //update the list box
            DisplaySuppliers();
        }
    }

    void DisplaySuppliers()
    {
        //create an instance of the supplier collection
        PhoneClasses.clsSupplierCollection Suppliers = new PhoneClasses.clsSupplierCollection();
        //set the data source to the list of counties in the collection
        lstSuppliers.DataSource = Suppliers.SupplierList;
        //set the name of the primary key 
        lstSuppliers.DataValueField = "SupplierID";
        //set the data field to display 
        lstSuppliers.DataTextField = "SupplierName";
        //bind the data to the list
        lstSuppliers.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to inidcate this is a new record 
        Session["SupplierID"] = 1;
        //redirect to the data entry page
        Response.Redirect("AddSupplier.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 SupplierID;
        //if a record has been selected from the list
        if (lstSuppliers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            SupplierID = Convert.ToInt32(lstSuppliers.SelectedValue);
            //store the data in the session object 
            Session["SupplierID"] = SupplierID;
            //redirect to the delete page
            Response.Redirect("DeleteSupplier.aspx");
        }
        else //if no record has been selected
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of teh record to be edited 
        Int32 SupplierID;
        //if the record has been selected fromt he list 
        if (lstSuppliers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            SupplierID = Convert.ToInt32(lstSuppliers.SelectedValue);
            //store the data in teh session object 
            Session["SupplierID"] = SupplierID;
            //redirect to the edit page 
            Response.Redirect("EditSupplier.aspx");
        }
        else //if no record has been selected 
        {
            //dipaly an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
