using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WPL
{
    public partial class SignUp : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUp_Button_Click(object sender, EventArgs e)
        {
            conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Register VALUES('" + email_textbox.Text + "','" + usernaam_textbox.Text + "','" + password_textbox.Text + "', '" + phone_textbox.Text + "') ", conn);
                cmd.ExecuteNonQuery();

                email_textbox.Text = "";
                usernaam_textbox.Text = "";
                password_textbox.Text = "";
                phone_textbox.Text = "";

                Response.Redirect("~/Default.aspx");
            
            
            conn.Close();

        }
    }
}