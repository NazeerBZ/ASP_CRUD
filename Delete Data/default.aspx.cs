using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Examination
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("insert into Student values('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"')",conn);

            cmd.ExecuteNonQuery();
            conn.Close();

            Label1.Visible = true;
            Label1.Text = "Data Has Been Sent!!";

            GridView1.DataBind();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("update Student set Name = '"+TextBox6.Text+"', Room_no = '"+TextBox7.Text+"', Institute = '"+TextBox8.Text+"' where Id = '"+Convert.ToInt32(TextBox5.Text).ToString()+"' ",conn);

            cmd.ExecuteNonQuery();
            conn.Close();

            Label2.Visible = true;
            Label2.Text = "Data Has Been Updated!!";

            GridView1.DataBind();

            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Student where Id = '"+Convert.ToInt32(TextBox9.Text).ToString()+"'", conn);

            cmd.ExecuteNonQuery();

            Label3.Visible = true;
            Label3.Text = "Data Has Been Deleted";

            GridView1.DataBind();

            TextBox9.Text = "";
        }
    }
}