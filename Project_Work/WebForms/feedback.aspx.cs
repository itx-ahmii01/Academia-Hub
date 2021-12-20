﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project_Work.WebForms
{
    public partial class feedback : System.Web.UI.Page
    {
        private static readonly string connString =
            System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            
            string cc = email.Text;
            string pass = message.Text;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into feed values (@email,@message)", con);
            cmd.Parameters.AddWithValue("@email", cc);
            cmd.Parameters.AddWithValue("@message", pass);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}