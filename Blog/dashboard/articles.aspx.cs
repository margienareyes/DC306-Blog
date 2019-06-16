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
    public partial class DashboardArticleList : System.Web.UI.Page
    {
        private SqlConnection SqlConnection;
        private SqlCommand SqlCommand;
        string connectionString = WebConfigurationManager.ConnectionStrings["Blog"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // grab all articles
            this.SqlConnection = new SqlConnection(this.connectionString);
            this.SqlConnection.Open();

            string isAdmin = Session["AuthorIsAdmin"] != null ? Session["AuthorIsAdmin"].ToString() : "";
            if (isAdmin == "True")
            {
                this.SqlCommand = new SqlCommand("SELECT " +
                    "Article.ArticleId as Id, Article.Title as Title, Article.Date as Date, Author.Name as Author " +
                    "FROM Article " +
                    "INNER JOIN Author ON Article.AuthorId = Author.AuthorId " +
                    "ORDER BY date", this.SqlConnection);
            } else
            {
                this.SqlCommand = new SqlCommand("SELECT " +
                    "Article.ArticleId as Id, Article.Title as Title, Article.Date as Date, Author.Name as Author " +
                    "FROM Article " +
                    "INNER JOIN Author ON Article.AuthorId = Author.AuthorId " +
                    "WHERE Article.AuthorId = @AuthorId " +
                    "ORDER BY date", this.SqlConnection);
                this.SqlCommand.Parameters.AddWithValue("@AuthorId", Session["AuthorId"] != null ? Session["AuthorId"] : 0);
            }

            this.SqlCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(this.SqlCommand);
            sqlDataAdapter.Fill(ds);
            this.DataList1.DataSource = ds;
            this.DataList1.DataBind();
        }

        protected void buttonEdit_Click(object sender, EventArgs e)
        {
            // goto /articles by id
            string key = (sender as LinkButton).CommandArgument;
            Response.Redirect("/dashboard/article.aspx?id=" + key);
        }
        protected void buttonDelete_Click(object sender, EventArgs e)
        {
            // delete article by id
            string key = (sender as LinkButton).CommandArgument;
            this.SqlConnection = new SqlConnection(this.connectionString);
            this.SqlConnection.Open();
            this.SqlCommand = new SqlCommand("DELETE FROM Article WHERE ArticleId=@id;", this.SqlConnection);
            this.SqlCommand.Parameters.AddWithValue("id", key);
            this.SqlCommand.ExecuteNonQuery();
        }
    }
}