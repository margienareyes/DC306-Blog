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
    public partial class WebForm1 : System.Web.UI.Page
    {
        private SqlConnection SqlConnection;
        private SqlCommand SqlCommand;
        string connectionString = WebConfigurationManager.ConnectionStrings["Blog"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // grab all articles and display on repeater
            this.SqlConnection = new SqlConnection(this.connectionString);
            this.SqlConnection.Open();
            this.SqlCommand = new SqlCommand("SELECT " +
                "Article.ArticleId as ArticleId, Article.ImagePath as ImagePath, Article.Title as Title, Article.Date as Date, Author.Name as Author, Article.Excerpt as Excerpt " +
                "FROM Article " +
                "INNER JOIN Author ON Article.AuthorId = Author.AuthorId " +
                "ORDER BY date", this.SqlConnection);
            this.SqlCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(this.SqlCommand);
            sqlDataAdapter.Fill(ds);
            this.DataList1.DataSource = ds;
            this.DataList1.DataBind();
        }
    }
}