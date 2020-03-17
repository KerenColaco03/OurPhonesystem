using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Registration : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=keren.database.windows.net;Initial Catalog=Phones;User ID=phone;Password=***********"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        
            
           

        }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
           
            string insertQuery = " insert into Customers (Firstname, Lastname, Email, Username, Password, Postcode, Country, Streetname, HouseNo, County) values ('" + TextBoxFN.Text + "', '" + TextBoxLN.Text + "',  '" + TextBoxPass.Text + "', '" + TextBoxEmail.Text + "','" + TextBoxUN.Text + "', '" + TextBoxStreet.Text + "', '" + TextBoxHouseNo.Text + "', '" + TextBoxCounty.Text + "', '" + TextBoxPost.Text + "', '" + DropDownListCountry.Text + "')";
            SqlCommand com = new SqlCommand(insertQuery, conn);

            conn.Open();

            
            com.ExecuteNonQuery();
            Response.Redirect("Default.aspx");
            Response.Write("Registration is successful");

            conn.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error" + ex.ToString());

        }
        Response.Write("You have registrattion is successful");

    }
}
