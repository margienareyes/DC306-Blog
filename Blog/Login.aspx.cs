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
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Blog"].ToString());
            SqlCommand SqlCommand = new SqlCommand("SELECT * FROM Author WHERE AuthorId=@AuthorId", con);
            SqlCommand.Parameters.AddWithValue("@AuthorId", authorId);

            try
            {
                con.Open();
                this.SqlDataReader = SqlCommand.ExecuteReader();
                while (this.SqlDataReader.Read())
                {
                    Session["AuthorId"] = this.SqlDataReader["AuthorId"].ToString();
                    Session["AuthorUsername"] = this.SqlDataReader["Username"].ToString();
                    Session["AuthorName"] = this.SqlDataReader["Name"].ToString();
                    Session["AuthorEmail"] = this.SqlDataReader["Email"].ToString();
                }
            }

            catch (Exception exception)
            {
                
            }

            con.Close();
        }
    }
}