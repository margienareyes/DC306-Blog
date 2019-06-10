using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using System.Configuration;

namespace Blog
{
    public partial class Register : System.Web.UI.Page
    {
        private SqlConnection conn; 
        private SqlCommand cmd; 
        String connStr = WebConfigurationManager.ConnectionStrings["Blog"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Blog"].ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [Author] where Username=@txtUsername";
            cmd.Parameters.AddWithValue("txtUsername", txtUsername.Text);
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)

            {
                Label1.Visible = true;
                Label1.Text = "Username already exist";
                labelStatus.Text = "";
            }
            else
            {
                conn = new SqlConnection(connStr);
                cmd = new SqlCommand("insert into [Author] (Name, Username, Password, Email) values (@Name , @Username, @Password, @Email)", conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);


                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    labelStatus.Text = "Thank you! You are now registered ";
                    Label1.Text = "";
                    txtName.Text = "";
                    txtUsername.Text = "";
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                 

                }
                catch (Exception exc)
                {
                    labelStatus.Text = exc.ToString();
                }
                conn.Close();
            }
        }

        protected void lnkLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
  }
