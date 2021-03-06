﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{

    public partial class Dashboard : System.Web.UI.MasterPage
    {
        public string name;
        public string username;
        public string email;
        public string imagePath;

        protected void Page_Load(object sender, EventArgs e)
        {   
            // route guard: check if session author id exists
            if (Session["AuthorId"] == null)
            {
                Response.Redirect("/login.aspx");
            }

            this.name = Session["AuthorIsAdmin"].ToString();
            this.username = Session["AuthorUsername"].ToString();
            this.email = Session["AuthorEmail"].ToString();
            this.imagePath = Session["AuthorImage"].ToString();
        }
    }
}