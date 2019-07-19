using System;
namespace Models {
	public class AnneeScolaire {
		private int iD;
		private string anneeScolaire;

		private Classe classe;

		private Etudiant etudiant;


        public AnneeScolaire(int iD, string anneeScolaire)
        {
            this.iD = iD;
            this.anneeScolaire = anneeScolaire;
        }

        public AnneeScolaire(int iD, string anneeScolaire, Classe classe, Etudiant etudiant)
        {
            this.iD = iD;
            this.anneeScolaire = anneeScolaire;
            this.classe = classe;
            this.etudiant = etudiant;
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string AnneeScolaire1
        {
            get { return anneeScolaire; }
            set { anneeScolaire = value; }
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
