using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;


public partial class AddSupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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



  


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("SupplierSearch.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
       
    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //add new record 
        Add();
        //all donne so redirect back to the main page
        Response.Redirect("SupplierSearch.aspx");
    }
}
