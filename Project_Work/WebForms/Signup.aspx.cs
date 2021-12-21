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
            if (isFormValid())
            {
                string Type = "NONE";

                //  dal objMyDal = new dal();

                int Found = 1;
                //    objMyDal.SignupCheck(FnameTxt.Text, LnameTxt.Text, EmailTxt.Text, PassTxt.Text, CityTxt.Text, PhoneTxt.Text, Type);

                if (Found == 0)
                {
                    Response.Write("<script> alert('User already Registered!'); </script>");
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }
            }

            ClearForm();


        }
        private void ClearForm()
        {

            full.Text = string.Empty;
            email.Text = string.Empty;

            pass.Text = string.Empty;
            password2.Text = string.Empty;
           
        }
        private bool isFormValid()
        {
           
            if (full.Text == "" ||
              email.Text == "" || pass.Text == "" ||
               password2.Text == "")
            {
                Response.Write("<script> alert('Please fill out all neccessary fields!'); </script>");
                return false;
            }

            if (pass.Text != password2.Text)
            {
                // Password mismatch
                password2.Focus();
                Response.Write("<script> alert('Password Mismatch'); </script>");
                return false;
            }

            return true;
        }

    }
}