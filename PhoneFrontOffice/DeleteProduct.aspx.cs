using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;

public partial class Delete : System.Web.UI.Page
{
    Int32 ProductID;
    //event hanlder for load event
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //get the number of the product to be deleted from teh sesssion object
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    void DeleteProducts()
    {
        //function to delete the selected record 
        //create a new instance of the product book
        clsProductCollection ProductBook = new clsProductCollection();
        //find the record to delete 
        ProductBook.ThisProduct.Find(ProductID);
        //delete the record
        ProductBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteProducts();
        //redirect back to the main page
        Response.Redirect("ProductsSearch.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("ProductsSearch.aspx");
    }
}