using PhoneClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RemoveCartItem : System.Web.UI.Page
{
    Int32 OrderLineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the numbr of the item deleted from the objehct session
        OrderLineID = Convert.ToInt32(Session["OrderLineID"]);
         //
    }
    
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteCartItem();
        //redirect back to main page 
        Response.Redirect("DisplayBasket.aspx");
    }
    void DeleteCartItem()
    {
        //fucntion to delte the selected record
        //create a new insatcne of the payment book
        clsOrderLineCollection OrderLineBook = new clsOrderLineCollection();
        //find the reocrd to delete
        OrderLineBook.ThisOrderLine.Find(OrderLineID);
        //delete the record
        OrderLineBook.Delete();
    }
    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}