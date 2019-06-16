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
    public partial class BlogArticleView : System.Web.UI.Page
    {
        private SqlConnection SqlConnection;
        private SqlCommand SqlCommand;
        SqlDataReader SqlDataReader;

        public string title = "12312";
        public string author;
        public string date;
        public string excerpt;
        public string imagePath;


        protected void Page_Load(object sender, EventArgs e)
        {
            // grab article by id
            string id = Request.QueryString["id"];
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Blog"].ToString());
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
                    // update display using article queried
                    title = this.SqlDataReader["Title"].ToString();
                    author = this.SqlDataReader["Author"].ToString();
                    date = this.SqlDataReader["Date"].ToString();
                    excerpt = this.SqlDataReader["Excerpt"].ToString();
                    imagePath = this.SqlDataReader["ImagePath"].ToString();
                    this.contentLiteral.Text = this.SqlDataReader["Content"].ToString();
                }
            }

            catch (Exception exception)
            {

            }

            SqlConnection.Close();
        }
    }
}