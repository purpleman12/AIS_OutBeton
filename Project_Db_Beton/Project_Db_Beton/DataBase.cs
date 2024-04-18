using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Db_Beton
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;port=3306;username=Developer;password=12345;Database=db.beton");
        MySqlCommand command = new MySqlCommand();

        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                 connection.Open();
            }                   
        }
        public void ClosedConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }        
        }
        public MySqlConnection GetConnection(){
            return connection;
        }
        
    }
}
