using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PracticaBDMagazin
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=COMPUTER;Initial Catalog=GroceryStore;Integrated Security=True");

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                
            }
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
