using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WPL
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void login_Click1(object sender, EventArgs e)
        {
            conn.Open();

            try { 

            SqlCommand cmd = new SqlCommand("SELECT UserName, Password FROM Register WHERE UserName = '" + user_name.Text + "' AND Password = '" + pass.Text + "' ", conn);

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);

            DataTable da_table = new DataTable();

            adpt.Fill(da_table);

            string name_Value = da_table.Rows[0][0].ToString();
            string pass_Value = da_table.Rows[0][1].ToString();

            if (name_Value == user_name.Text && pass_Value == pass.Text)
            {
                Session["UserName"] = name_Value;
                Response.Redirect("~/Welcome.aspx");
            }

            }
            catch{
            
                incorrect.Visible = true;
                incorrect.Text = "*UserName & Password is Incorrect";
                user_name.Text = "";
            
            }

            conn.Close();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SignUp.aspx");
        }

      
    }
}