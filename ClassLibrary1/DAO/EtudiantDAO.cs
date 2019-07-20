using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ClassLibrary;
using Models;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace DAO
{
    public class EtudiantDAO
    {
        private SqlConnection connection;

        public EtudiantDAO()
        {
            connection = Singleton.GetInstance().GetConnection();
        }

        public Etudiant GetEtudiant(int idEtudiant)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var etudiant = db.Query("Etudiant").Where("IdEtudiant", idEtudiant).FirstOrDefault<Etudiant>();
                return etudiant;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Etudiant DAO Get Etudiant : " + ex.Message);
                return null;
            }
        }

        public IEnumerable<Etudiant> GetEtudiants()
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var etudiants = db.Query("Etudiant").GetAsync<Etudiant>().GetAwaiter().GetResult();
                if (etudiants.Count() == 0)
                    return null;
                return etudiants;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Etudiant DAO Get Etudiants : " + ex.Message);
                return null;
            }
        }

        public int UpdateEtudiant(Etudiant etudiant)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var rs = db.Query("Etudiant").Where("IdEtudiant", etudiant.IdEtudiant).Update(new
                {
                    etudiant.NomEtudiant,
                    etudiant.NomEtudiantArabe,
                    etudiant.PrenomEtudiant,
                    etudiant.PrenomEtudiantArabe,
                    etudiant.Cne,
                    etudiant.Cni,
                    etudiant.Massar,
                    etudiant.DateDeNaissance,
                    etudiant.DateInscription,
                    etudiant.LieuDeNaissance,
                    etudiant.LienDeNaissanceArabe,
                    etudiant.Adresse,
                    etudiant.AdresseArabe,
                    etudiant.NumInsricption
                });
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Etudiant DAO Update : " + ex.Message);
                return 0;
            }
        }

        public int DeleteEtudiant(int idEtudiant)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var rs = db.Query("Etudiant").Where("IdEtudiant", idEtudiant).Delete();
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Etudiant DAO Delete : " + ex.Message);
                return 0;
            }
        }

        public int InsertEtudiant(Etudiant etudiant)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var rs = db.Query("Etudiant").Insert(new
                {
                    etudiant.NomEtudiant,
                    etudiant.NomEtudiantArabe,
                    etudiant.PrenomEtudiant,
                    etudiant.PrenomEtudiantArabe,
                    etudiant.Cne,
                    etudiant.Cni,
                    etudiant.Massar,
                    etudiant.DateDeNaissance,
                    etudiant.DateInscription,
                    etudiant.LieuDeNaissance,
                    etudiant.LienDeNaissanceArabe,
                    etudiant.Adresse,
                    etudiant.AdresseArabe,
                    etudiant.NumInsricption
                });
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Etudiant DAO Insert : " + ex.Message);
                return 0;
            }
        }
    }
}
