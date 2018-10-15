using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JanesClothingDB.Data_Access_Layer
{
    class ConnectionManager
    {
        //establishing connection between the application and database

        //instantiating SqlConnection object
        public static SqlConnection DatabaseConnection()
        {
            string connection = "Data Source=laptop-hq36brdd\\sqlexpress; Initial Catalog=Sales; User=sa; Password=sqlexpress";
            SqlConnection conn = new SqlConnection(connection);
            return conn;
        }
    }
}
