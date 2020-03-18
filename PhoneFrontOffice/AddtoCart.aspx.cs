using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;

public partial class AddtoCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        {
            //
            //add the nee record
            Add();
            //all done so redirect back to main page
            Response.Redirect("DisplayBasket.aspx");
        }

    }

    protected void btnContinueShopping_Click(object sender, EventArgs e)
    {

    }
    void Add()
    {
        //create an intance of teh address book
        clsOrderLineCollection OrderLineBook = new clsOrderLineCollection();
        //valdate th edta on the web form
        String Error = OrderLineBook.ThisOrderLine.Valid(txtQuantity.Text);
        //if the dtaa is OK then add it ot the object
        if (Error == "")
        {
            //gte the dtaa entered by the user
            OrderLineBook.ThisOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);
            
            //add the record
            OrderLineBook.Add();
            Response.Redirect("DisplayBasket.aspx");

        }
        else
        {
            //report an error
            lblError.Text = "there were problems with the data entered" + Error;

        }

    }
}
