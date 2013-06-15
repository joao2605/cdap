using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace AEIS
{
    class DBHandler
    {
        public static SqlConnection constr;
        public static String connString = "Data Source=NEON-LAP\\SQLEXPRESS; Initial Catalog=aeis; Integrated Security=SSPI; Persist Security Info=false; Trusted_Connection=Yes";
            //ConfigurationManager.ConnectionStrings["AEISConstring"].ConnectionString;

        public static SqlConnection getConnection()
        {
            constr = new SqlConnection(connString);

            return constr;
        }
    }
}
