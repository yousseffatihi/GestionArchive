using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Models {
	public class AnneeScolaire {

        /// <summary>
        /// Attributes
        /// </summary>
		private int idAnneeScolaire;
		private string annee;

        /// <summary>
        /// Associations
        /// </summary>
		private Classe classe;
		private Etudiant etudiant;

        /// <summary>
        /// Defualt Constructor
        /// </summary>
        /// <param name="idAnneeScolaire"></param>
        /// <param name="annee"></param>
        public AnneeScolaire(int idAnneeScolaire, string annee)
        {
            this.idAnneeScolaire = idAnneeScolaire;
            this.annee = annee;
        }

        /// <summary>
        /// This Contructor is made to initialize all attributes and associations
        /// </summary>
        /// <param name="idAnneeScolaire"></param>
        /// <param name="annee"></param>
        /// <param name="classe"></param>
        /// <param name="etudiant"></param>
        public AnneeScolaire(int idAnneeScolaire, string annee, Classe classe, Etudiant etudiant) : this(idAnneeScolaire, annee)
        {
            this.classe = classe;
            this.etudiant = etudiant;
        }

        [Column(IsPrimaryKey = true, Name = "IdAnneeScolaire")]
        public int IdAnneeScolaire
        {
            get { return idAnneeScolaire; }
            set { idAnneeScolaire = value; }
        }

        [Column(Name = "Annee")]
        public string Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        [Column(Name = "IdClasse")]
        public Classe Classe
        {
            get { return classe; }
            set { classe = value; }
        }
        [Column(Name = "IdEtudiant")]
        public Etudiant Etudiant
        {
            get { return etudiant; }
            set { etudiant = value; }
        }

        public override string ToString()
        {
            return $"IdAnneeScolaire : {IdAnneeScolaire}, Annee : {Annee}";
        }
    }
}
