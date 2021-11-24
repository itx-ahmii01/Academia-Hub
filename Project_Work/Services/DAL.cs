using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace Project_Work.Services
{
    public class DAL
    {
        public int signup(int id,string password)
        {
            // call the sp  //

             using (IDbConnection Db = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString))
             {
                try
                {
                    string readSp = "Signup"; // procedure name 
                    DynamicParameters values = new DynamicParameters();
                    values.Add("@D_Name", password);
                    values.Add("@output", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    Db.Query(readSp, values, commandType: CommandType.StoredProcedure);
                    return values.Get<int>("@output");
                }
                catch
                {
                    return -1;
                }
             }
                
        }
    }
}