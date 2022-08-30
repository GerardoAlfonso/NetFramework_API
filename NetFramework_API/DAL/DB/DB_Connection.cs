using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NetFramework_API.DAL.DB
{
    public class DB_Connection
    {
        //singleton
        private static DB_Connection objConnection;
        private SqlConnection sqlConnection;

        //Builder
        private DB_Connection()
        {
            sqlConnection = new SqlConnection("Data Source=PC-SAMUEL\\MSSQLSERVER2019;Initial Catalog=colegio;Integrated Security=True");
        }

        public static DB_Connection CreateConnection()
        {
            if (objConnection == null)
            {
                objConnection = new DB_Connection();
            }
            return objConnection;
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

        public void CloseConnection()
        {
            objConnection = null;
        }
    }
}