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
        public static String connString = ConfigurationManager.ConnectionStrings["AEISConstring"].ConnectionString;

        public static SqlConnection getConnection()
        {
            constr = new SqlConnection(connString);

            return constr;
        }
    }
}
