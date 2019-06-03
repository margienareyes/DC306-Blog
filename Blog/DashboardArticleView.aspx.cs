using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using System.Web;

namespace Blog
{
    public partial class DashboardArticleView : System.Web.UI.Page
    {
        private SqlConnection SqlConnection;
        string connectionString = WebConfigurationManager.ConnectionStrings["Blog"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.SqlConnection = new SqlConnection(this.connectionString);

        }

        protected void buttonSave_Click(object sender, EventArgs e)
        {
            SqlCommand SqlCommand = new SqlCommand("" +
                "INSERT INTO Article (Title, Content) VALUES (@Title, @Content);",
                this.SqlConnection);

            SqlCommand.Parameters.AddWithValue("@Title", this.textboxTitle.Text);
            SqlCommand.Parameters.AddWithValue("@Content", this.textboxContent.Text);

            this.SqlConnection.Open();
            try
            {
                int x = SqlCommand.ExecuteNonQuery();
                this.labelStatus.Text = x.ToString();
            }
            catch (Exception exception)
            {
                this.labelStatus.Text = exception.ToString();
            }

            this.SqlConnection.Close();
        }
    }
}