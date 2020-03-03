using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PhonesConnectionString"].ConnectionString);
        conn.Open();
        string checkuser = "select count(*) from UserData where Username = '" + txtUsername.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
        if (temp == 1)
        {
            conn.Open();
            string CheckPasswordQuery = " select Password from UserData  Where Username= '" + txtUsername.Text + "'";
            SqlCommand passCom = new SqlCommand(CheckPasswordQuery, conn);
            string password = passCom.ExecuteScalar().ToString().Replace(" ", "");
            if (password == txtPassword.Text)
            {
                Session["New"] = txtUsername.Text;
                Response.Write("password is correct");
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Write("password is NOT correct");
            }
        }
        else
        {
            Response.Write("UserName is NOT correct");
        }
    }
}