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
    public partial class Subscribe : System.Web.UI.Page
    {
        private static readonly string connString =
System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                string nem = name.Text;
                string id1 = id.Text;
                string cc = card.Text;
                string pass = password.Text;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Subscribe values (@name,@card,@password,@id)", con);
                cmd.Parameters.AddWithValue("@name", nem);
                cmd.Parameters.AddWithValue("@card", cc);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@id", id1);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ee)
            {
               
            }
        }
    }
}