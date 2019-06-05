using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace Blog
{
    public partial class DashboardAuthorView : System.Web.UI.Page
    {
        private SqlConnection conn; //create a connection object
        private SqlCommand cmd; //create a command object ArtSchoolDB
        String connStr = WebConfigurationManager.ConnectionStrings["Blog"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonSave_Click(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("insert into [Author] (Name, Username, Password, Email) values (@Name,@Username,@Password,@Email)", conn);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Username", txtUser.Text);
            cmd.Parameters.AddWithValue("@Password", txtPass.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
  
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();

                labelStatus.Text = "Thank you for registering ! ";
            }
            catch (Exception exc)

            {
                labelStatus.Text = exc.ToString();
            }


            conn.Close();
        }
    }
}

