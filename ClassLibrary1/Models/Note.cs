using System;
namespace Models {
	public class Note {
        /// <summary>
        /// Attributes
        /// </summary>
		private int idNote;
		private string nomMatiere;
		private double noteMatiere;
		private int coefMatiere;

        /// <summary>
        /// Associations
        /// </summary>
		private Classe classe;
		private Etudiant etudiant;

        /// <summary>
        /// Default Contructor
        /// </summary>
        /// <param name="idNote"></param>
        /// <param name="nomMatiere"></param>
        /// <param name="noteMatiere"></param>
        /// <param name="coefMatiere"></param>
        public Note(int idNote, string nomMatiere, double noteMatiere, int coefMatiere)
        {
            this.idNote = idNote;
            this.nomMatiere = nomMatiere;
            this.noteMatiere = noteMatiere;
            this.coefMatiere = coefMatiere;
        }

        /// <summary>
        /// This Contructor is made to initialize all attributes and associations
        /// </summary>
        /// <param name="idNote"></param>
        /// <param name="nomMatiere"></param>
        /// <param name="noteMatiere"></param>
        /// <param name="coefMatiere"></param>
        /// <param name="classe"></param>
        /// <param name="etudiant"></param>
        public Note(int idNote, string nomMatiere, double noteMatiere, int coefMatiere, Classe classe, Etudiant etudiant) : this(idNote, nomMatiere, noteMatiere, coefMatiere)
        {
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

        /// <summary>
        /// ToString Function
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Id Note : {idNote}, Nom Matiere {nomMatiere}, Note Mateire {noteMatiere}, CoefMatiere {CoefMatiere}";
        }
    }
}
