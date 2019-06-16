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
    public partial class BlogArticleView : System.Web.UI.Page
    {
        private SqlConnection SqlConnection;
        private SqlCommand SqlCommand;
        string connectionString = WebConfigurationManager.ConnectionStrings["ArtSchoolDB"].ConnectionString;
        SqlDataReader SqlDataReader;

        protected void Page_Load(object sender, EventArgs e)
        {
            //string id = Request.QueryString["id"]; 
            //this.SqlConnection = new SqlConnection(this.connectionString);
            //this.SqlCommand = new SqlCommand("SELECT Id, day, time, topic, tutor FROM Schedule WHERE Id=@id", this.SqlConnection);
            //this.SqlCommand.Parameters.AddWithValue("@id", id);

            //try
            //{
            //    this.SqlConnection.Open();
            //    this.SqlDataReader = this.SqlCommand.ExecuteReader();
            //    while (this.SqlDataReader.Read())
            //    {
            //        this.textboxDay.Text = this.SqlDataReader["day"].ToString();
            //        this.textboxTime.Text = this.SqlDataReader["time"].ToString();
            //        this.textboxTopic.Text = this.SqlDataReader["topic"].ToString();
            //        this.textboxTutor.Text = this.SqlDataReader["tutor"].ToString();
            //        this.textboxId.Text = this.SqlDataReader["Id"].ToString();
            //    }
            //}

            //catch (Exception exception)
            //{
            //    this.labelStatus.Text = exception.Message;
            //}

            //this.SqlConnection.Close();
        }
    }
}