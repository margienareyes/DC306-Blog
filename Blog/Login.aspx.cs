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
        SqlDataReader SqlDataReader;
        protected void Page_Load(object sender, EventArgs e)
        {
            // check if query string is logout
            string isLogout = Request.QueryString["logout"];
            if (isLogout == "1")
            {   
                logout();
            }
        }

        protected void logout()
        {
            // clear session
            Session.Remove("AuthorId");
            Session.Remove("AuthorUsername");
            Session.Remove("AuthorName");
            Session.Remove("AuthorEmail");
            Session.Remove("AuthorImage");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        { 

            // check username && password match on db
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Blog"].ToString());
            con.Open();
                string query = "SELECT * FROM Author where Username='" + txtUsername.Text + "'and Password='" + txtPassword.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            string output = Convert.ToString(cmd.ExecuteScalar());

            if (output != "")
            {
                Session["user"] = txtUsername.Text;
                this.saveSession(Int32.Parse(output));
                Response.Redirect("dashboard/index.aspx");
            }
            else
            {
                Response.Write("<script>alert('User do not exist!');</script>");
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
            con.Close();
        }

        private void saveSession(int authorId)
        {
            // grab author info by id
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Blog"].ToString());
            SqlCommand SqlCommand = new SqlCommand("SELECT * FROM Author WHERE AuthorId=@AuthorId", con);
            SqlCommand.Parameters.AddWithValue("@AuthorId", authorId);

            try
            {
                con.Open();
                this.SqlDataReader = SqlCommand.ExecuteReader();
                while (this.SqlDataReader.Read())
                {
                    // save session
                    Session["AuthorId"] = this.SqlDataReader["AuthorId"].ToString();
                    Session["AuthorUsername"] = this.SqlDataReader["Username"].ToString();
                    Session["AuthorName"] = this.SqlDataReader["Name"].ToString();
                    Session["AuthorEmail"] = this.SqlDataReader["Email"].ToString();
                    Session["AuthorImage"] = this.SqlDataReader["ImagePath"].ToString();
                }
            }

            catch (Exception exception)
            {
                
            }

            con.Close();
        }
    }
}