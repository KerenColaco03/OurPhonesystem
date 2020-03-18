using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;

public partial class AddProduct : System.Web.UI.Page
{
    

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //create a new instance of clsProduct
        //clsProduct AProduct = new clsProduct();
        //capture the brand
        //AProduct.Brand = txtBrand.Text;
        //capture the product type
        //AProduct.ProductType = txtProductType.Text;
        //AProduct.Capacity = ddlCapacity.Text;
        //AProduct.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
        //AProduct.Price = Convert.ToDouble(txtPrice.Text);
        //AProduct.Colour = ddlColour.Text;
        //store the product in the session object
        //Session["AProduct"] = AProduct;
        //redirect to the viewer page
        //Response.Redirect("ProductAdded.aspx");

        //add new record 
        Add();
        //all doen so redirect back to the main page
        Response.Redirect("ProductsSearch.aspx");
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



    protected void btnBack_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("ProductsSearch.aspx");
    }
}

    

    


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
    

