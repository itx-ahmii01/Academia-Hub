using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project_Work.WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        private static readonly string connString =
           System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["Username"] != null)
            {
                Response.Redirect("~/homepage.aspx");
            }
            if (!IsPostBack)
            {
                if (Request.Cookies["UNAME"] != null && Request.Cookies["UPWD"] != null)
                {
                    name.Text = Request.Cookies["UNAME"].Value;
                    password.Text = Request.Cookies["UPWD"].Value;
                    
                }
            }

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
           
                string email = name.Text;
                string pass = password.Text;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into login values (@email,@password)", con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", pass);

                cmd.ExecuteNonQuery();
                con.Close();

            if (isFormValid())
            {
                // dal objMyDal = new dal();

                int Found = 1;
                //objMyDal.SearchUser(name.Text, password.Text);

                if (Found == 1)
                {
                   
                    Session["Username"] = name.Text;

                    Response.Redirect("~/homepage.aspx");
                }
                else
                {
                    Response.Write("<script> alert('Invalid Email or Password!'); </script>");
                }
            }

            else
            {
                Response.Write("<script> alert('Please fill out all fields!'); </script>");
            }



            ClearForm();

        }
        private void ClearForm()
        {
            name.Text = string.Empty;
            password.Text = string.Empty;
        }
        private bool isFormValid()
        {
            if (name.Text == "" || password.Text == "")
            {
                return false;
            }

            return true;
        }




    }
       
    }
