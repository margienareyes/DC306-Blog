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
    public partial class DashboardArticleView : System.Web.UI.Page
    {
        private SqlConnection SqlConnection;
        string connectionString = WebConfigurationManager.ConnectionStrings["Blog"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Request.QueryString["parameter1"];
            this.SqlConnection = new SqlConnection(this.connectionString);

        }

        protected void buttonSave_Click(object sender, EventArgs e)
        {
            SqlCommand SqlCommand = new SqlCommand("INSERT INTO " +
                "Article (Title) " +
                "VALUES (@Title)",
                this.SqlConnection);

            SqlCommand.Parameters.AddWithValue("@Title", this.textboxTitle.Text);
            // SqlCommand.Parameters.AddWithValue("@FK_AuthorArticle", 1);


            try
            {
                this.SqlConnection.Open();
                if (SqlCommand.ExecuteNonQuery() == 1)
                {
                    this.labelStatus.Text = "New user is successfully added! Thank you.";
                }
            }
            catch (Exception exception)
            {
                this.labelStatus.Text = exception.ToString();
            }

            this.SqlConnection.Close();
        }

    }
}