using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Models;
using SqlKata.Compilers;
using SqlKata.Execution;


namespace DAO
{
    public class NoteDAO
    {
        private SqlConnection connection;

        public NoteDAO()
        {
            connection = Singleton.GetInstance().GetConnection();
        }

        public Note GetNote(int idNote)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var note = db.Query("Note").Where("IdNote", idNote).FirstOrDefault<Note>();
                return note;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note DAO Get Note : " + ex.Message);
                return null;
            }
        }

        public IEnumerable<Note> GetNotes()
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var notes = db.Query("Note").GetAsync<Note>().GetAwaiter().GetResult();
                if (notes.Count() == 0)
                    return null;
                return notes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note DAO Get Notes : " + ex.Message);
                return null;
            }
        }

        public int UpdateNote(Note note)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var rs = db.Query("Note").Where("IdNote", note.IdNote).Update(new
                {
                    note.NomMatiere,
                    note.NoteMatiere,
                    note.CoefMatiere,
                    note.Classe.IdClasse,
                    note.Etudiant.IdEtudiant
                });
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note DAO Update : " + ex.Message);
                return 0;
            }
        }

        public int DeleteNote(int idNote)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var rs = db.Query("Note").Where("IdNote", idNote).Delete();
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note DAO Delete : " + ex.Message);
                return 0;
            }
        }

        public int InsertNote(Note note)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var rs = db.Query("Note").Insert(new
                {
                    note.NomMatiere,
                    note.NoteMatiere,
                    note.CoefMatiere,
                    note.Classe.IdClasse,
                    note.Etudiant.IdEtudiant
                });
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note DAO Insert : " + ex.Message);
                return 0;
            }
        }
    }
}
