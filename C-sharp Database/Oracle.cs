using System;  
using Oracle.DataAccess.Client;  
using System.Data;

public class oracle
{
	public static void Main(string[] args) {  
    string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= system;Password=system;";  
    
        OracleConnection conn = new OracleConnection(oradb);  
          try
        {    Console.WriteLine("Oracle Connection Opening...");
             conn.Open();  
	Console.WriteLine(" Connected to Oracle" + conn.ServerVersion+"\n");  
         string oracle = "select name from client_master";
        OracleCommand cmd = new OracleCommand(oracle,conn);

        OracleDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
            {
                Console.WriteLine(dr[0]);
            }
	dr.Close();
	}
	  catch(Exception ex)
	  { Console.WriteLine(ex.ToString());
 	  }

	conn.Close();  
        Console.WriteLine("\n Connection Closed");  
    }  }
