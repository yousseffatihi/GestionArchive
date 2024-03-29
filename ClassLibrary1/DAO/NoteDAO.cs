﻿using System;
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
                var IdClasse = db.Query("Note").Where("IdNote", idNote).Select("IdClasse").FirstOrDefault<Int32>();
                note.Classe = new ClasseDAO().GetClasse(IdClasse);
                var IdEtudiant = db.Query("Note").Where("IdNote", idNote).Select("IdEtudiant").FirstOrDefault<Int32>();
                note.Etudiant = new EtudiantDAO().GetEtudiant(IdEtudiant);   
                return note;
            }
            catch (Exception ex)
            {
                throw ex;
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
                for (int i = 0; i < notes.Count(); i++)
                {
                    var IdClasse = db.Query("Note").Where("IdNote", notes.ElementAt(i).IdNote).Select("IdClasse").FirstOrDefault<Int32>();
                    notes.ElementAt(i).Classe = new ClasseDAO().GetClasse(IdClasse);
                    var IdEtudiant = db.Query("Note").Where("IdNote", notes.ElementAt(i).IdNote).Select("IdEtudiant").FirstOrDefault<Int32>();
                    notes.ElementAt(i).Etudiant = new EtudiantDAO().GetEtudiant(IdEtudiant);
                }
                return notes;
            }
            catch (Exception ex)
            {
                throw ex;
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
                    note.Etudiant.IdEtudiant,
                    note.Semestre
                });
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
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
                throw ex;
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
                    note.Etudiant.IdEtudiant,
                    note.Semestre
                });
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
