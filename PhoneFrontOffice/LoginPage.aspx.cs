using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class LoginPage : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=keren.database.windows.net;Initial Catalog=Phones;User ID=phone;Password=***********");

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {


        string strcon = "Data Source=keren.database.windows.net;Initial Catalog=Phones;User ID=phone;Password=***********";
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("CUser", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;
        SqlParameter p1 = new SqlParameter("username", txtUsername.Text);
        SqlParameter p2 = new SqlParameter("password", txtPassword.Text);
        com.Parameters.Add(p1);
        com.Parameters.Add(p2);
        con.Open();
        SqlDataReader rd = com.ExecuteReader();
        if (rd.HasRows)
        {
            Response.Redirect("AddPage.aspx");
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

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}
         




       