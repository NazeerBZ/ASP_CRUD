using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examination
{
    public partial class LoginPage : System.Web.UI.Page
    {
             
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand("select Marks, Grade from Login where Username = '"+TextBox1.Text+"' AND Password = '"+TextBox2.Text+"' ", conn))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {

                        using (DataTable dt = new DataTable())
                        {

                            da.Fill(dt);

                            GridView1.DataSource = dt;
                            GridView1.DataBind();

                        }

                    }

                }

            }
                
        }
          
        
    }
}