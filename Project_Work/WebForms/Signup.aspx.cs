using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Project_Work.Services;

namespace academia_hub
{
    public partial class Signup : System.Web.UI.Page
    {
        private static readonly string connString =
System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signup_Click(object sender, EventArgs e)
        {
            try
            {
                String FullName = this.full.Text;
                String email_1 = this.email.Text;
                String pass_1 = this.pass.Text;
                String pass_2 = this.password2.Text;

                SqlConnection con = new SqlConnection(connString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Student (name,email,password,id) values (@nem,@eemail,@ppasword,@id)", con);
                cmd.Parameters.AddWithValue("@nem", FullName);
                cmd.Parameters.AddWithValue("@eemail", email_1);
                cmd.Parameters.AddWithValue("@ppasword", pass_1);
                Random r = new Random();
                cmd.Parameters.AddWithValue("@id", r.Next()%100);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ee)
            {
                Label1.Visible = true;
                Label1.Text = ee.Message;
            }
               // int found = obj.signup(full.Text,);
            

        }
        private bool isFormValid()
        {
            if (FnameTxt.Text == "" || LnameTxt.Text == "" ||
               EmailTxt.Text == "" || PassTxt.Text == "" ||
               CPassTxt.Text == "" || PhoneTxt.Text == "")
            {
                Response.Write("<script> alert('Please fill out all neccessary fields!'); </script>");
                return false;
            }

            if (.Text != CPassTxt.Text)
            {
                // Password mismatch
                CPassTxt.Focus();
                Response.Write("<script> alert('Password Mismatch'); </script>");
                return false;
            }

            return true;
        }

    }
}