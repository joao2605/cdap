using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AEIS
{
    class DBAccess
    {
        //global variable for database connectivity
        public SqlConnection connection;

        public DBAccess()
        {
            //get connection
            this.connection = DBHandler.getConnection();
        }

        
        

    }//end of the class
}
