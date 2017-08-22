using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class SqlHelper
    {

        private const string ConnectionString = "Database=. ; Database=busComp ; Integrated Security=true;";

        public static SqlCommand CreateSqlCommand()
        {
            SqlConnection sqlConn = new SqlConnection();
            sqlConn.ConnectionString = ConnectionString;

            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;

            return sqlComm;

        }
    }
}
