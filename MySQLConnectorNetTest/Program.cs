using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLConnectorNetTest
{
    class Program
    {
        //note:需先安装mysql数据库和MySQL Connector Net，然后引用MySql.Data.dll
        static void Main(string[] args)
        {
            string connStr = "server=localhost;user=root;database=guiconfig;port=3306;password=fmi-drooga;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                // Perform databse operations
                string sql = "SELECT Name, password FROM fmi_user_account WHERE access_level='supervisor'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");

            //System.Reflection.Assembly info = conn.GetType().Assembly;
            //Console.WriteLine(info);
        }
    }
}
