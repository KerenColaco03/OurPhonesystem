using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewOrders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to e delted
        Int32 OrderID;
        //if a record had been slected fromt he list
        if (lstOrder.SelectedIndex != -1)
        {
            //gte th eprimary key value of te rcord to dlete
            OrderID = Convert.ToInt32(lstOrder.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //REDIRECT TO DEETE PAGE
            Response.Redirect("DeleteOrder.aspx");


        }
        else
        {
            //if no record has been selected
            lblError.Text = "please select a rcord to delete from the list";

        }
    }

    protected void lstPayments_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }
}