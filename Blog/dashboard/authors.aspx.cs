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
    public partial class DashboardAuthorList : System.Web.UI.Page
    {
        private SqlConnection SqlConnection;
        private SqlCommand SqlCommand;
        string connectionString = WebConfigurationManager.ConnectionStrings["Blog"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // grab all authors
            this.SqlConnection = new SqlConnection(this.connectionString);
            this.SqlConnection.Open();
            this.SqlCommand = new SqlCommand("SELECT AuthorId, Name, Username, Email FROM Author ORDER BY AuthorId", this.SqlConnection);
            this.SqlCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(this.SqlCommand);
            sqlDataAdapter.Fill(ds);
            this.DataList1.DataSource = ds;
            this.DataList1.DataBind();
        }
        protected void buttonEdit_Click(object sender, EventArgs e)
        {
            // goto /author by id
            string key = (sender as LinkButton).CommandArgument;
            Response.Redirect("/dashboard/author.aspx?id=" + key);
        }
        protected void buttonDelete_Click(object sender, EventArgs e)
        {
            // delete author by id
            string key = (sender as LinkButton).CommandArgument;
            this.SqlConnection = new SqlConnection(this.connectionString);
            this.SqlConnection.Open();
            this.SqlCommand = new SqlCommand("DELETE FROM Author WHERE AuthorId=@id;", this.SqlConnection);
            this.SqlCommand.Parameters.AddWithValue("id", key);

        }
    }
}