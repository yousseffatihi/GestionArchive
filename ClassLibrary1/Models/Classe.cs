using System;
using System.Collections.Generic;

namespace Models {
	public class Classe {
		private int idClasse;
		private string nomClasse;
		private string niveauClasse;

		private System.Collections.Generic.List<Note> notes;
		private System.Collections.Generic.List<AnneeScolaire> anneesScolaires;

        
        public Classe(int idClasse, string nomClasse, string niveauClasse)
        {
            this.idClasse = idClasse;
            this.nomClasse = nomClasse;
            this.niveauClasse = niveauClasse;
        }

        public Classe(int idClasse, string nomClasse, string niveauClasse, List<Note> notes, List<AnneeScolaire> anneesScolaires) : this(idClasse, nomClasse, niveauClasse)
        {
            this.notes = notes;
            this.anneesScolaires = anneesScolaires;
        }

        public int IdClasse
        {
            get { return idClasse; }
            set { idClasse = value; }
        }

        public string NomClasse
        {
            get { return nomClasse; }
            set { nomClasse = value; }
        }

        public string NiveauClasse
        {
            get { return niveauClasse; }
            set { niveauClasse = value; }
        }

        public List<Note> Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public List<AnneeScolaire> AnneesScolaires
        {
            get { return anneesScolaires; }
            set { anneesScolaires = value; }
        }

        public override string ToString()
        {
            return $"Id Classe : {idClasse} \t Nom Classe : {nomClasse} \t Niveau Classe : {niveauClasse}";
        }
    }

}
