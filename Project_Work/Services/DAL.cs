using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using System.IO;

namespace Project_Work.Services
{
    public class DAL
    {
        private static readonly string connString = "";

        public int SearchUser(String Email, String pass)
        {
            int Found = 0;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Login_Check", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@email", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 10);

                cmd.Parameters.Add("@flag", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@email"].Value = Email;

                cmd.Parameters["@password"].Value = pass;


                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@flag"].Value); //convert to output parameter to interger format

                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

            return Found;

        }

        public int SignupCheck(String FullName, String email_1,String pass_1,
        String pass_2)


        {
            int Found = 0;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Signup_Check", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

               
                cmd.Parameters.Add("@Fullname", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 10);

                cmd.Parameters.Add("@flag", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
             
                cmd.Parameters["@Fullname"].Value = FullName;
                cmd.Parameters["@email"].Value = email_1;
                cmd.Parameters["@password"].Value = pass_1;
             


                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@flag"].Value); //convert to output parameter to interger format

                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

            return Found;
        }


        //public int signup(int id,string password)
        //{
        //    // call the sp  //

        //     using (IDbConnection Db = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString))
        //     {
        //        try
        //        {
        //            string readSp = "Signup"; // procedure name 
        //            DynamicParameters values = new DynamicParameters();
        //            values.Add("@D_Name", password);
        //            values.Add("@output", dbType: DbType.Int32, direction: ParameterDirection.Output);

        //            Db.Query(readSp, values, commandType: CommandType.StoredProcedure);
        //            return values.Get<int>("@output");
        //        }
        //        catch
        //        {
        //            return -1;
        //        }
        //     }

        //}
    }
}