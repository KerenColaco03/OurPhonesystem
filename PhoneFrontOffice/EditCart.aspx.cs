using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;
public partial class EditCart : System.Web.UI.Page
{
    Int32 OrderLineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //
        //get the number of orderlines to be processes 
        OrderLineID = Convert.ToInt32(Session["OrderLineID"]);
        if (IsPostBack == false)
        {
            //populate the list of orderlines
            DisplayOrderLines();
            //if this is not a new record
            if (OrderLineID != -1)
            {
                //display the current data for the recor
                DisplayOrderLines();
            }
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (OrderLineID == -1)
        {
            //AddedControl the new reocrd
            Add();
        }
        else
        {
            ////updatd the reocrd
            Update();
        }
    }


    void Add()
    {
        //create an intance of the Payment Book
        PhoneClasses.clsOrderLineCollection OrderLineBook = new PhoneClasses.clsOrderLineCollection();
        //validate the data on the web form
        String Error = OrderLineBook.ThisOrderLine.Valid(txtQuantity.Text);
        //if the dta is ok then ad it to the object
        if (Error == "")
        {
            //find the record to update
            OrderLineBook.ThisOrderLine.Find(OrderLineID);
            //get the dta entered by the user

            OrderLineBook.ThisOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);

            //update the record
            OrderLineBook.Add();
            //all done so redirect to the main page 
            Response.Redirect("DisplayBasket.aspx");

        }
    }
        //fucntion for updating records
        void Update()
    {
        //create an intance of the Payment Book
        PhoneClasses.clsOrderLineCollection OrderLineBook = new PhoneClasses.clsOrderLineCollection();
        //validate the data on the web form
        String Error = OrderLineBook.ThisOrderLine.Valid(txtQuantity.Text);
        //if the dta is ok then ad it to the object
        if (Error == "")
        {
            //find the record to update
            OrderLineBook.ThisOrderLine.Find(OrderLineID);
            //get the dta entered by the user

            OrderLineBook.ThisOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);

            //update the record
            OrderLineBook.Update();
            //all done so redirect to the main page 
            Response.Redirect("DisplayBasket.aspx");

        }
        else
        {
            //report an error
            lblError.Text = "There were problems wit the data entered " + Error;

        }

    }
    void DisplayOrderLines()
    {

        //create an omstance of the Orderline book
        clsOrderLineCollection OrderLineBook = new clsOrderLineCollection();
        //find the record to update
         OrderLineBook.ThisOrderLine.Find(OrderLineID);
        //display the data for this record
        txtQuantity.Text = OrderLineBook.ThisOrderLine.Quantity.ToString();
    }

    protected void btnContinueShopping_Click(object sender, EventArgs e)
    {

    }
}





