using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;

public partial class Edit : System.Web.UI.Page
{
    Int32 ProductID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the products to be processed
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            //populate the list of products
            DisplayProducts();
            //if this is not a new record 
            if (ProductID != -1)
            {
                //display the current data for the record 
                DisplayProducts();
            }
            

            }
        }
    

    //function for updating records
    void Update()
    {
        //create an instance of the Product book
        PhoneClasses.clsProductCollection ProductBook = new PhoneClasses.clsProductCollection();
        //validate the data from the web form
        String Error = ProductBook.ThisProduct.Valid(txtBrand.Text, ddlCapacity.Text, ddlColour.Text, txtPrice.Text, txtProductQuantity.Text, txtProductType.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            ProductBook.ThisProduct.Find(ProductID);
            //get the data entered by the user 
            ProductBook.ThisProduct.Brand = txtBrand.Text;
            ProductBook.ThisProduct.Capacity = ddlCapacity.SelectedValue;
            ProductBook.ThisProduct.Colour = ddlCapacity.SelectedValue;
            ProductBook.ThisProduct.Price = Convert.ToDouble(txtPrice.Text);
            ProductBook.ThisProduct.ProductQuantity = Convert.ToInt32(txtProductQuantity);
            ProductBook.ThisProduct.ProductType = txtProductType.Text;
            //update the record
            ProductBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("ProductsSearch.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    //event hanlder for the ok button 
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (ProductID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();

        }
    }

    void Add()
    {
        //create an instance of the products book
        clsProductCollection ProductBook = new clsProductCollection();
        //validate the data on the web form
        String Error = ProductBook.ThisProduct.Valid(txtBrand.Text, ddlCapacity.Text, ddlColour.Text, txtPrice.Text, txtProductQuantity.Text, txtProductType.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            ProductBook.ThisProduct.Brand = txtBrand.Text;
            ProductBook.ThisProduct.Capacity = ddlCapacity.SelectedValue;
            ProductBook.ThisProduct.Colour = ddlColour.SelectedValue;
            ProductBook.ThisProduct.Price = Convert.ToDouble(txtPrice.Text);
            ProductBook.ThisProduct.ProductQuantity = Convert.ToInt32(txtProductQuantity);
            ProductBook.ThisProduct.ProductType = txtProductType.Text;
            //add the record
            ProductBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("ProductsSearch.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }


    void DisplayProducts()
    {
        //create an instance of the product book
        clsProductCollection ProductBook = new clsProductCollection();
        //find the record to update 
        ProductBook.ThisProduct.Find(ProductID);
        //display the data for this record
        txtBrand.Text = ProductBook.ThisProduct.Brand;
        ddlCapacity.SelectedValue = ProductBook.ThisProduct.Capacity;
        ddlColour.SelectedValue = ProductBook.ThisProduct.Colour;
        txtPrice.Text = ProductBook.ThisProduct.Price.ToString();
        txtProductQuantity.Text = ProductBook.ThisProduct.ProductQuantity.ToString();
        txtProductType.Text = ProductBook.ThisProduct.ProductType;

    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("ProductsSearch.aspx");
    }
}