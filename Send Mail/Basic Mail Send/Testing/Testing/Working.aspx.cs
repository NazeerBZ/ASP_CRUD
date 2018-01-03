using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace Testing
{
    public partial class Working : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("nazeeridreesi381@gmail.com");
            msg.To.Add(TextBox1.Text);
            msg.Subject = TextBox2.Text;
            msg.Body = TextBox3.Text;
            msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";

            System.Net.NetworkCredential NetwokrCred = new System.Net.NetworkCredential();
            NetwokrCred.UserName = "nazeeridreesi381@gmail.com";
            NetwokrCred.Password = "allah ho akbar 381";

            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetwokrCred;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(msg);

            Label5.Visible = true;
            Label5.Text = "Email Has Been Sent!!";

        }


    }
}