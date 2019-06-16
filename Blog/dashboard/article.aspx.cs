using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using System.IO;

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
                "INSERT INTO Article (Title, Content, ImagePath, AuthorId, Date, Excerpt) VALUES (@Title, @Content, @ImagePath, @AuthorId, @Date, @Excerpt);",
                this.SqlConnection);

            string filename = fileUploadImage.FileName;
            string path = Server.MapPath("../public/");

            SqlCommand.Parameters.AddWithValue("@Title", this.textboxTitle.Text);
            SqlCommand.Parameters.AddWithValue("@Content", this.textboxContent.Text);
            SqlCommand.Parameters.AddWithValue("@AuthorId", Session["AuthorId"]);
            SqlCommand.Parameters.AddWithValue("@ImagePath", "/public/" + filename);
            SqlCommand.Parameters.AddWithValue("@Date", DateTime.Now);
            SqlCommand.Parameters.AddWithValue("@Excerpt", this.textboxExcerpt.Text);

            this.SqlConnection.Open();
            try
            {
                if (SqlCommand.ExecuteNonQuery() == 1)
                {
                    if (fileUploadImage.HasFile) {
                        string ext = Path.GetExtension(filename);
                        if (ext == ".jpg" || ext == ".png")
                        {
                            fileUploadImage.PostedFile.SaveAs(path + filename);
                        }
                    }

                    this.labelStatus.Text = "Article saved succesfully";
                    this.clearForm();
                }
            }
            catch (Exception exception)
            {
                this.labelStatus.Text = exception.ToString();
            }

            this.SqlConnection.Close();
        }

        protected void clearForm()
        {
            this.textboxTitle.Text = "";
            this.textboxContent.Text = "";
        }
    }
}