using ClassLibrary1;
using Models;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class ClasseDAO
    {
        private SqlConnection connection;

        public ClasseDAO()
        {
            connection = Singleton.GetInstance().GetConnection();
        }

        public Classe GetClasse(int idClasse)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var classe = db.Query("Classe").Where("IdClasse", idClasse).FirstOrDefault<Classe>();
                Console.WriteLine(classe);
                return classe;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
