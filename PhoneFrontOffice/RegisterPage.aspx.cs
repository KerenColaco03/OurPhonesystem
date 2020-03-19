using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class RegisterPage : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=keren.database.windows.net;Initial Catalog=Phones;User ID=phone;Password=***********");

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {


        string strcon = "Data Source=keren.database.windows.net;Initial Catalog=Phones;User ID=phone;Password=***********";
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("CUser", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;
        SqlParameter p1 = new SqlParameter("Firstname", TextBoxFN.Text);
        SqlParameter p2 = new SqlParameter("Lastname", TextBoxLN.Text);
        SqlParameter p3 = new SqlParameter("Email", TextBoxEmail.Text);  

        SqlParameter p4 = new SqlParameter("password", TextBoxPass.Text);
        SqlParameter p5 = new SqlParameter("Postcode", TextBoxPost.Text);
        SqlParameter p6 = new SqlParameter("Username", TextBoxUN.Text);
        SqlParameter p7 = new SqlParameter("County", TextBoxCounty.Text);
        SqlParameter p8 = new SqlParameter("Country", DropDownListCountry.Text);
        SqlParameter p9 = new SqlParameter("HouseNo", TextBoxHouseNo.Text);
        SqlParameter p10 = new SqlParameter("Streetname", TextBoxStreet.Text);

        com.Parameters.Add(p1);
        com.Parameters.Add(p2);
        com.Parameters.Add(p3);
        com.Parameters.Add(p4);
        com.Parameters.Add(p5);
        com.Parameters.Add(p6);
        com.Parameters.Add(p7);
        com.Parameters.Add(p8);
        com.Parameters.Add(p9);
        com.Parameters.Add(p10);
        con.Open();
        SqlDataReader rd = com.ExecuteReader();
        if (rd.HasRows)
        {
            rd.Read();
            Label3.Text = "Login successful.";
            Label3.Visible = true;
        }
        else
        {
            Label3.Text = "Invalid username or password.";
            Label3.Visible = true;

        }
    }
}
                
        

















    