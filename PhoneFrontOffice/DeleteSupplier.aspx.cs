using PhoneClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteSupplier : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supplier to be deleted from the session object 
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
    }

    void DeleteSuppliers()
    {
        //function to delete the selected record 
        //create a new instance of the product book
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to delete 
        SupplierBook.ThisSupplier.Find(SupplierID);
        //delete the record
        SupplierBook.Delete();
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        //deleete the record
        DeleteSuppliers();
        //redirect back to the main page
        Response.Redirect("SupplierSearch.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("SupplierSearch.aspx");
    }
}