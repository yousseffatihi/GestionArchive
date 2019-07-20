using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ClassLibrary
{
    public class Singleton
    {
        private SqlConnection connection = null;
        private static Singleton _instance = null;

        public Singleton()
        {
            try
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=LyceeIbnSina;Integrated Security=False;User ID=sa;Password=123456;";
                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Signleton : " + ex.Message);
            }
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton();
            return _instance;
        }

        public SqlConnection GetConnection()
        {
            return this.connection;
        }
    }
}
