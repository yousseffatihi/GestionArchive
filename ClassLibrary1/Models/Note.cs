using System;
namespace Models {
	public class Note {
		private int idNote;
		private string nomMatiere;
		private double noteMatiere;
		private int coefMatiere;

		private Classe classe;

		private Etudiant etudiant;

        public Note(int idNote, string nomMatiere, double noteMatiere, int coefMatiere)
        {
            this.idNote = idNote;
            this.nomMatiere = nomMatiere;
            this.noteMatiere = noteMatiere;
            this.coefMatiere = coefMatiere;
        }

        public Note(int idNote, string nomMatiere, double noteMatiere, int coefMatiere, Classe classe, Etudiant etudiant)
        {
            this.idNote = idNote;
            this.nomMatiere = nomMatiere;
            this.noteMatiere = noteMatiere;
            this.coefMatiere = coefMatiere;
            this.classe = classe;
            this.etudiant = etudiant;
        }

        public int IdNote
        {
            get { return idNote; }
            set { idNote = value; }
        }

        public string NomMatiere
        {
            get { return nomMatiere; }
            set { nomMatiere = value; }
        }

        public double NoteMatiere
        {
            get { return noteMatiere; }
            set { noteMatiere = value; }
        }

        public int CoefMatiere
        {
            get { return coefMatiere; }
            set { coefMatiere = value; }
        }

        public Classe Classe
        {
            get { return classe; }
            set { classe = value; }
        }

        public Etudiant Etudiant
        {
            get { return etudiant; }
            set { etudiant = value; }
        }
    }

}
