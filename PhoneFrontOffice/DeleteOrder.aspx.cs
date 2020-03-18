using PhoneClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteOrder : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the numbr of the item deleted from the objehct session
        OrderID = Convert.ToInt32(Session["OrderID"]);

    }
    void DeleteOrders()
    {
        //fucntion to delte the selected record
        //create a new insatcne of the payment book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the reocrd to delete
        OrderBook.ThisOrder.Find(OrderID);
        //delete the record
        OrderBook.Delete();
    }


    protected void btnNo_Click(object sender, EventArgs e)
    {

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteOrders();
        //redirect back to main page 
        Response.Redirect("ViewOrders.aspx");
    }
}