﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using System.Configuration;

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

        protected void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Blog"].ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [Author] where Username=@txtUser";
            cmd.Parameters.AddWithValue("txtUser", txtUser.Text);
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)

            {
                Label1.Visible = true;
                Label1.Text = "Username already exist";
                labelStatus.Text = "";
            }
            else
            {
                conn = new SqlConnection(connStr);
                cmd = new SqlCommand("insert into [Author] (Name, LastName, Username, Password) values (@Name, @LastName,@Username,@Password)", conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Username", txtUser.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    labelStatus.Text = "Thank you for registering ! ";
                    Label1.Text = "";
                    txtName.Text = "";
                    txtUser.Text = "";
                   
                    txtPass.Text = "";
                    txtLastName.Text = "";
                }
                catch (Exception exc)
                {
                    labelStatus.Text = exc.ToString();
                }
                conn.Close();
            }
        }
    }
}
               








