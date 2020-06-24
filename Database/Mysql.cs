using System;
using MySql.Data;
using MySql.Data.MySqlClient;
public class mysql
{
    public static void Main(string[] args)
    {
       
         string mysql = "server=localhost;user=root;database=MYDB;port=3306;password=''";
      MySqlConnection conn = new MySqlConnection(mysql);

        try
	{    Console.WriteLine("Mysql Connection Opening...\n");
            conn.Open();
	 Console.Write(" Connected to Mysql" +" "+  conn.ServerVersion+"\n\n");

     	  string sql = "SELECT name FROM user";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr[0]);
            }
            rdr.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
	conn.Close();
        Console.WriteLine("\n Connection closed.");
    }
}

