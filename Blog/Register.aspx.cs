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
using System.IO;

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
                string filename = fileUploadImage.FileName;
                string path = Server.MapPath("public/authors");

                conn = new SqlConnection(connStr);
                cmd = new SqlCommand("insert into [Author] (Name, Username, Password, Email, ImagePath) values (@Name , @Username, @Password, @Email, @ImagePath)", conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@ImagePath", "/public/authors" + filename);


                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    if (fileUploadImage.HasFile)
                    {
                        string ext = Path.GetExtension(filename);
                        if (ext == ".jpg" || ext == ".png")
                        {
                            fileUploadImage.PostedFile.SaveAs(path + filename);
                        }
                    }

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
