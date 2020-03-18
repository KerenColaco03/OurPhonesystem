using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class ProductsSearch : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayProducts();
        }

    }

    void DisplayProducts()
    {
        //create an instance of the products collection
        PhoneClasses.clsProductCollection Products = new PhoneClasses.clsProductCollection();
        //set the data source to the list of counties in the collection
        lstProducts.DataSource = Products.ProductList;
        //set the name of the primary key
        lstProducts.DataValueField = "ProductID";
        //set the data field tp display
        lstProducts.DataTextField = "ProductType";
        lstProducts.DataTextField = "Brand";
        //bing the data to the list
        lstProducts.DataBind();       
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ProductID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AddProduct.aspx");
    }



    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 ProductID;
        //if a record has been selected from the list
        if (lstProducts.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            ProductID = Convert.ToInt32(lstProducts.SelectedValue);
            //store the data in the session object 
            Session["ProductID"] = ProductID;
            //redirect to the delete page
            Response.Redirect("DeleteProduct.aspx");
        }
        else //if no record has been selected
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 ProductID;
        //if a record has been selected from the list
        if (lstProducts.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            ProductID = Convert.ToInt32(lstProducts.SelectedValue);
            //store the data in the session object 
            Session["ProductID"] = ProductID;
            //redirect to the edit page
            Response.Redirect("AddProduct.aspx");
        }
        else // if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }

    }


    protected void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }



    protected void btnApply_Click(object sender, EventArgs e)
    {

    }
}