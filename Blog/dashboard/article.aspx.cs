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
        public string id;
        SqlDataReader SqlDataReader;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.SqlConnection = new SqlConnection(this.connectionString);
            this.id = Request.QueryString["id"];
            
            // ispostback
            if (IsPostBack)
            {
                return;
            }

            // if id url query, grab article by id
            if (id != null)
            {

                SqlCommand SqlCommand = new SqlCommand("SELECT " +
                    "Article.ArticleId as ArticleId, Article.ImagePath as ImagePath, Article.Title as Title, Article.Date as Date, Author.Name as Author, Article.Excerpt as Excerpt, Article.Content as Content  " +
                    "FROM Article " +
                    "INNER JOIN Author ON Article.AuthorId = Author.AuthorId " +
                    "WHERE ArticleId=@ArticleId", SqlConnection);
                SqlCommand.Parameters.AddWithValue("@ArticleId", id);

                try
                {
                    SqlConnection.Open();
                    this.SqlDataReader = SqlCommand.ExecuteReader();
                    while (this.SqlDataReader.Read())
                    {
                        // update textboxes using article 
                        textboxTitle.Text = this.SqlDataReader["Title"].ToString();
                        textboxExcerpt.Text = this.SqlDataReader["Excerpt"].ToString();
                        textboxContent.Text = this.SqlDataReader["Content"].ToString();
                    }
                }

                catch (Exception exception)
                {

                }

                SqlConnection.Close();
            }
        }

        protected void buttonSave_Click(object sender, EventArgs e)
        {
            SqlCommand SqlCommand;

            // if url query, do update
            if (this.id != null)
            {
                SqlCommand = new SqlCommand("" +
                    "UPDATE Article " +
                    "SET Title=@Title, Excerpt=@Excerpt, Content=@Content,  ImagePath=@ImagePath " +
                    "WHERE ArticleId=@ArticleId",
                    this.SqlConnection);
                SqlCommand.Parameters.AddWithValue("ArticleId", id);
            } else
            {
                SqlCommand = new SqlCommand("" +
                    "INSERT INTO Article (Title, Content, ImagePath, AuthorId, Date, Excerpt) VALUES (@Title, @Content, @ImagePath, @AuthorId, @Date, @Excerpt);",
                    this.SqlConnection);
            }

            string filename = fileUploadImage.FileName;
            string path = Server.MapPath("../public/");



            SqlCommand.Parameters.AddWithValue("@Title", this.textboxTitle.Text);
            SqlCommand.Parameters.AddWithValue("@Content", this.textboxContent.Text);
            SqlCommand.Parameters.AddWithValue("@AuthorId", Session["AuthorId"]);
            SqlCommand.Parameters.AddWithValue("@Date", DateTime.Now);
            SqlCommand.Parameters.AddWithValue("@Excerpt", this.textboxExcerpt.Text);

            if (filename != null)
            {
                SqlCommand.Parameters.AddWithValue("@ImagePath", "/public/" + filename);
            }

            this.SqlConnection.Open();
            try
            {
                if (SqlCommand.ExecuteNonQuery() == 1)
                {
                    // image
                    if (fileUploadImage.HasFile) {
                        string ext = Path.GetExtension(filename);
                        if (ext == ".jpg" || ext == ".png")
                        {
                            fileUploadImage.PostedFile.SaveAs(path + filename);
                        }
                    }

                    if (id != null)
                    {
                        this.labelStatus.Text = "Article updated succesfully";
                    }
                    else
                    {
                        this.labelStatus.Text = "Article saved succesfully";
                        this.clearForm();
                    }
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
            // clear the form
            this.textboxTitle.Text = "";
            this.textboxContent.Text = "";
            this.textboxExcerpt.Text = "";
        }
    }
}