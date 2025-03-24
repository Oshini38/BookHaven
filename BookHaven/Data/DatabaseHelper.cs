using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data
{
   public class DatabaseHelper
    {
        //simplify and centralize database connection management

        private static readonly string connectionString = "Server=DESKTOP-TRFFJ42;Database=BookHavenDB;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
