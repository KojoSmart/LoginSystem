using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LoginSystem
{
    internal class db

    {
        public static String connectionString = "server=localhost; database=youtube; uid =root; pwd=\"\";";

         public static MySqlConnection connection = new MySqlConnection(connectionString);


        public static void openConnection()
        {
            try
            {
                if(connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error connecting to the database");
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error trying to terminate  the database");
            }
        }

    }
}
