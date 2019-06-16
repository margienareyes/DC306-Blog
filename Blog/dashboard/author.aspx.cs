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
    public partial class DashboardAuthorView : System.Web.UI.Page
    {
        private SqlConnection conn; //create connection
        private SqlCommand cmd;  // create command
        String connStr = WebConfigurationManager.ConnectionStrings["Blog"].ConnectionString;
        public string id;
        SqlDataReader SqlDataReader;
        protected void Page_Load(object sender, EventArgs e)
        {

            this.id = Request.QueryString["id"];

            // magic sauce
            if (IsPostBack)
            {
                return;
            }

            // if url query, get article by id
            if (id != null)
            {

                SqlConnection con = new SqlConnection(this.connStr);
                SqlCommand SqlCommand = new SqlCommand("SELECT * FROM Author WHERE AuthorId=@AuthorId", con);
                SqlCommand.Parameters.AddWithValue("@AuthorId", id);

                try
                {
                    con.Open();
                    this.SqlDataReader = SqlCommand.ExecuteReader();
                    while (this.SqlDataReader.Read())
                    {
                        // and display on textbox
                        txtName.Text = this.SqlDataReader["Name"].ToString();
                        txtEmail.Text = this.SqlDataReader["Email"].ToString();
                        txtUser.Text = this.SqlDataReader["Username"].ToString();
                        txtPass.Text = this.SqlDataReader["Password"].ToString();
                        txtConPass.Text = this.SqlDataReader["Password"].ToString();
                    }
                }

                catch (Exception exception)
                {

                }

                con.Close();
            }

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Blog"].ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand();

            // if url query, do update
            if (id != null)
            {
                cmd.CommandText = "" +
                    "UPDATE Author " +
                    "SET Name=@Name, Email=@Email, Username=@Username,  ImagePath=@ImagePath, Password=@Password " +
                    "WHERE AuthorId=@AuthorId";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("AuthorId", id);
                con.Close();
                return;
            }


            // else save new

            // check username duplicate
            cmd.CommandText = "select * from [Author] where Username=@txtUser";
            cmd.Parameters.AddWithValue("txtUser", txtUser.Text);
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
                string path = Server.MapPath("../public/authors");

                conn = new SqlConnection(connStr);
                cmd = new SqlCommand("insert into [Author] (Name, Email, Username, Password, ImagePath, IsSuperAdmin) values (@Name,@Email,@Username,@Password, @ImagePath, @IsSuperAdmin)", conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Username", txtUser.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                cmd.Parameters.AddWithValue("@ImagePath", "/public/authors" + filename);
                cmd.Parameters.AddWithValue("@IsSuperAdmin", this.checkboxIsAdmin.Checked);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    if (fileUploadImage.HasFile)
                    {
                        // image
                        string ext = Path.GetExtension(filename);
                        if (ext == ".jpg" || ext == ".png")
                        {
                            fileUploadImage.PostedFile.SaveAs(path + filename);
                        }
                    }

                    // clear
                    labelStatus.Text = "Thank you! You are now registered ";
                    Label1.Text = "";
                    txtName.Text = "";
                    txtUser.Text = "";
                    txtEmail.Text = "";
                    txtPass.Text = "";

                }
                catch (Exception exc)
                {
                    labelStatus.Text = exc.ToString();
                }
                conn.Close();
            }
        }
    }
}






