using PhoneClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EnterOrderdetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //
        //add a new record
        Add();
        //all done so redirect back to main page
        Response.Redirect("ViewOrders.aspx");
    }
    void Add()
    {
        //create an intance of teh address book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //valdate th edta on the web form
        String Error = OrderBook.ThisOrder.Valid(txtCustomerID.Text,txtTotalPrice.Text,txtOrderDate.Text);
        //if the dtaa is OK then add it ot the object
        if (Error == "")
        {
            //gte the dtaa entered by the user
            OrderBook.ThisOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            OrderBook.ThisOrder.TotalPrice= Convert.ToDouble(txtTotalPrice.Text);
            OrderBook.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);

            //add the record
            OrderBook.Add();
            Response.Redirect("ViewOrders.aspx");

        }
        else
        {
            //report an error
            lblError.Text = "there were problems with the data entered" + Error;

        }

    }
}