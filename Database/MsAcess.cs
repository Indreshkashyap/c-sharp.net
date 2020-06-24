using System;
using System.Data;
using System.Data.OleDb;  

namespace acess
{
    public class msacess
    {
        public static void Main(string[] args)
        {

        OleDbConnection con = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=ind.accdb");
	con.Open();
  	string macess = "select * from table1";
	OleDbCommand cmd = new OleDbCommand(macess,con);
	OleDbDataReader dr = cmd.ExecuteReader();

	while (dr.Read())
         {
                Console.WriteLine(dr[1]);
           }
        	dr.Close();
	con.Close();
	}

        }
    }
