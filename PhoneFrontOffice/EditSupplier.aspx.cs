using PhoneClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditSupplier : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supplier to be processed 
        SupplierID = Convert.ToInt32(Session["SupplierNo"]);
        if (IsPostBack == false)
        {
            //populate the list of suppliers
            DisplaySupplier();
            //if this is not a new record
            if (SupplierID != -1)
            {
                //display the current data for the record
                DisplaySupplier();

            }
        }
    }

    void Update()
    {
        //create an instance of the Product book
        PhoneClasses.clsSupplierCollection SupplierBook = new PhoneClasses.clsSupplierCollection();
        //validate the data from the web form
        String Error = SupplierBook.ThisSupplier.Valid(txtSupplierName.Text, txtSupplierDate.Text, txtProductID.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            SupplierBook.ThisSupplier.Find(SupplierID);
            //get the data entered by the user 
            SupplierBook.ThisSupplier.SupplierName = txtSupplierName.Text;
            SupplierBook.ThisSupplier.SupplierDate = Convert.ToDateTime(txtSupplierDate);
            //update the record
            SupplierBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("SupplierSearch.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (SupplierID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    }

    void Add()
    {
        //create an instance of the suppliers book
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //validate the data on the web form
        String Error = SupplierBook.ThisSupplier.Valid(txtSupplierName.Text, txtSupplierDate.Text, txtProductID.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            SupplierBook.ThisSupplier.SupplierName = txtSupplierName.Text;
            SupplierBook.ThisSupplier.SupplierDate = Convert.ToDateTime(txtSupplierDate);
            //add the record
            SupplierBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("SupplierSearch.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    void DisplaySupplier()
    {
        //create an instance of the supplierbook
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to update 
        SupplierBook.ThisSupplier.Find(SupplierID);
        //display the data for this record 
        txtSupplierName.Text = SupplierBook.ThisSupplier.SupplierName;
        txtSupplierDate.Text = SupplierBook.ThisSupplier.SupplierDate.ToString();
    }





    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierSearch.aspx");
    }
}
