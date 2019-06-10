using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Blog
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        { 
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Blog"].ToString());
        con.Open();
            string query = "SELECT * FROM Author where Username='" + txtUsername.Text + "'and Password='" + txtPassword.Text + "'";

        SqlCommand cmd = new SqlCommand(query, con);

        string output = Convert.ToString(cmd.ExecuteScalar());

            if (output != "")
            {
                Session["user"] = txtUsername.Text;
                Response.Redirect("DashboardAuthorView.aspx");
            }
            else
            {
                Response.Write("<script>alert('User do not exist!');</script>");
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
            con.Close();
        }
    }
}