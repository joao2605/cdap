using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AEIS
{

    /// <summary>
    /// Summary description for DB_Connect
    /// </summary>
    public class DB_Connect
    {


        public static string srConnectionString = "Data Source=NEON-LAP\\SQLEXPRESS; Initial Catalog=AEIS; Integrated Security=SSPI; Persist Security Info=false; Trusted_Connection=Yes";

        public DB_Connect()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        public static DataSet ExecuteQuery(String strSql)
        {

            DataSet dSet = new DataSet();

            try
            {
                using (SqlConnection connection = new SqlConnection(srConnectionString))
                {
                    connection.Open();
                    SqlDataAdapter DA = new SqlDataAdapter(strSql, connection);
                    DA.Fill(dSet);
                }
                return dSet;
            }
            catch (Exception)
            {
                using (SqlConnection connection = new SqlConnection(srConnectionString))
                {
                    if (srConnectionString.IndexOf("select Id from tblAspErrors") != -1)
                    {
                        connection.Open();
                        strSql = strSql.Replace("'", "''");
                        SqlCommand command = new SqlCommand("insert into tblSqlErrors values ('" + strSql + "')", connection);
                        command.ExecuteNonQuery();
                    }
                }
                return dSet;
            }
        }

        public static bool InsertQuery(String strSql)
        {

            int result = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(srConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(strSql, connection);
                    result = command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                strSql = strSql.Replace("'", "''");
                using (SqlConnection connection = new SqlConnection(srConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into tblSqlErrors values ('" + strSql + "')", connection);
                    result = command.ExecuteNonQuery();
                }

            }

            if (result == 1)
                return true;
            else
                return false;
            
        }

    }

}
