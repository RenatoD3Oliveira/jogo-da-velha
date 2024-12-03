using System;
using System.Data.SqlClient;

namespace jogo_da_velha.controller
{
    internal class Connection
    {
        private static SqlConnection con;
        private static readonly object lockObj = new object();

        private static string DataBase = "JOGODAVELHA";
        private static string Server = @"MUSHU";

        private Connection() { } 

        public static SqlConnection ReturnConnect()
        {
            if (con == null || con.State == System.Data.ConnectionState.Closed)
            {
                lock (lockObj)
                {
                    if (con == null || con.State == System.Data.ConnectionState.Closed)
                    {
                        string strinConnection = $@"Data Source={Server}; Initial Catalog={DataBase}; Integrated Security=True; Encrypt=true; TrustServerCertificate=true";
                        con = new SqlConnection(strinConnection);
                        con.Open();
                    }
                }
            }
            return con;
        }

        public static void CloseConnect()
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
