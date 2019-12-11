using System;
using MySql.Data.MySqlClient;

namespace Blogging
{
    class DB
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=1234;database=db");
        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return con;
        }
    }
}
