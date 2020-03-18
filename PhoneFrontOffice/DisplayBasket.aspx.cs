using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DisplayBasket : System.Web.UI.Page
{
    Int32 OrderLineID;
    //this function handles the load veent for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time th epage is displayed
        OrderLineID = Convert.ToInt32(Session["OrderLineID"]);
        if(IsPostBack == false)
        {
            //UPDATE THE LIST BOX
            DisplayOrderLines();
        }
    }
    void DisplayOrderLines()
    {
        //create an insance of the OrderlINEcOLLECTION
        PhoneClasses.clsOrderLineCollection AnOrderLine = new PhoneClasses.clsOrderLineCollection();
        //set the dtaa source to th elist of orderiines in the collecton
        lstCart.DataSource = AnOrderLine.OrderLineList;
        //set the name of the primary key
        lstCart.DataValueField = "OrderLineID";
        lstCart.DataTextField = "ProductID";
        lstCart.DataTextField = "Quantity";
        lstCart.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirect to data entry page
        Response.Redirect("EnterOrderDetails.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to e delted
        Int32 OrderLineID;
        //if a record had been slected fromt he list
        if (lstCart.SelectedIndex != -1)
        {
            //gte th eprimary key value of te rcord to dlete
            OrderLineID = Convert.ToInt32(lstCart.SelectedValue);
            //store the data in the session object
            Session["OrderLineID"] = OrderLineID;
            //REDIRECT TO DEETE PAGE
            Response.Redirect("RemoveCartItem.aspx");


        }
        else
        {
            //if no record has been selected
            lblError.Text = "please select a rcord to delete from the list";

        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        //var to toe the primarykey vaue of he record to bve edited
        Int32 OrderLineID;
        //if a record hads been sleected from the list
        if (lstCart.SelectedIndex != -1)
        {
            //get the primary key value of the record ot edit
            OrderLineID = Convert.ToInt32(lstCart.SelectedValue);
            //stiore the dtaa i the session object
            Session["OrderLineID"] = OrderLineID;
            //rdirect to the edit page
            Response.Redirect("EditCart.aspx");
        }
        else
        {
            //display an error 
            lblError.Text = "please slect a rcord to delete from the list";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}