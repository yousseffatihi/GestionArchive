using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    class Singleton
    {
        private SqlConnection connection = null;
        public static Singleton _instance = null;

        public Singleton()
        {
            try
            {
                connection = new SqlConnection("Data Source=192.168.1.6;Integrated Security=False;User ID=sa;Password=123456;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
