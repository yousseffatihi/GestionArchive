using System;
using System.Collections.Generic;

namespace Models {
	public class Classe {
        /// <summary>
        /// Attributes
        /// </summary>
		private int idClasse;
		private string nomClasse;
		private string niveauClasse;
        /// <summary>
        /// Associations
        /// </summary>
		private List<Note> notes;
		private List<AnneeScolaire> anneesScolaires;

        /// <summary>
        /// Defualt Constructors
        /// </summary>
        /// <param name="idClasse"></param>
        /// <param name="nomClasse"></param>
        /// <param name="niveauClasse"></param>
        public Classe(int idClasse, string nomClasse, string niveauClasse)
        {
            this.idClasse = idClasse;
            this.nomClasse = nomClasse;
            this.niveauClasse = niveauClasse;
        }

        /// <summary>
        /// This Contructor is made to initialize all attributes and associations
        /// </summary>
        /// <param name="idClasse"></param>
        /// <param name="nomClasse"></param>
        /// <param name="niveauClasse"></param>
        /// <param name="notes"></param>
        /// <param name="anneesScolaires"></param>
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
        /// <summary>
        /// ToString Function
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Id Classe : {idClasse} \t Nom Classe : {nomClasse} \t Niveau Classe : {niveauClasse}";
        }
    }

}
