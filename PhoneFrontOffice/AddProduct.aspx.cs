using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //create a new instance of clsProduct
        //clsProduct AProduct = new clsProduct();
        //capture the brand
       // AProduct.Brand = txtBrand.Text;
        //store the product in the session object
        //Session["AProduct"] = AProduct;
        //capture the product type
        //AProduct.ProductType = txtProductType.Text;
        //AProduct.Capacity =
        //AProduct.StockQuantity = txtProductQuanity.Text;
       // AProduct.Price = txtPrice.Text;
       // AProduct.Colour = ddlColour.Text;
        //redirect to the viewer page
        Response.Redirect("ProductAdded.aspx");
    }
}