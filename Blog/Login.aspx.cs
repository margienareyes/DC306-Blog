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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["blogdb"].ToString());
        con.Open();
            string query = "SELECT * FROM Author where email='" + txtEmail.Text + "'and Password='" + txtPassword.Text + "'";

        SqlCommand cmd = new SqlCommand(query, con);

        string output = Convert.ToString(cmd.ExecuteScalar());

            if (output != "")
            {
                Session["user"] = txtEmail.Text;
                Response.Redirect("DashboardAuthorView.aspx");
            }
            else
            {
                Response.Write("User do not exist!");
            }
            con.Close();
        }
    }
}