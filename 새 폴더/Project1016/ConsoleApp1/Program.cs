
/*  SMITH
ALLEN
WARD
JONES
MARTIN
BLAKE
CLARK
SCOTT
KING
TURNER
ADAMS
JAMES
FORD
MILLER
*/



using System;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {




            string str = @"Data source= (DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = topcredu)
    )
  ); User Id=scott; Password=tiger ; Provider=OraOleDB.Oracle";

            OleDbConnection Conn = new OleDbConnection(str);
            OleDbCommand Comm;
            Comm = new OleDbCommand();
            Comm.Connection = Conn;
            try
            {
                Conn.Open();
                Comm.CommandText = "SELECT ENAME FROM EMP";
                OleDbDataReader reader = Comm.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(reader.GetOrdinal("ENAME")));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }

        }
    }
}
