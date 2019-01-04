using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mchoice
{
    public class DBConnect
    {
        public static MySqlConnection connection;
        public static string server;
        public static string database;
        public static string uid;
        public static string password;

       

        public static void Initialize()
        {
            server = "83.212.96.191";
            database = "MC";
            uid = "root";
            password = "mplemilo";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            OpenConnection();
        }

        //open connection to database
        public static bool OpenConnection()
        {
            
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server. Contact Admin");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


        public bool checkIfUserExists(string username, string password)
        {
            string query = "SELECT count(*) FROM User WHERE username = '" + username + 
                "' AND password = '" + password +"'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            dataReader.Read();
            if ( Convert.ToInt32(dataReader[0].ToString()) == 1)
            {
                dataReader.Close();
                return true;
            }

            dataReader.Close();
            return false;
        }
        
    }

    
}