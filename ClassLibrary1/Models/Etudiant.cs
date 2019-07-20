using System;
using System.Collections.Generic;

namespace Models {
	public class Etudiant {
        /// <summary>
        /// Attributes
        /// </summary>
		private int idEtudiant;
		private string nomEtudiant;
		private string nomEtudiantArabe;
        private string prenomEtudiant;
        private string prenomEtudiantArabe;
        private string cne;
        private string cni;
        private string massar;
        private DateTime dateDeNaissance;
        private DateTime dateInscription;
        private string lieuDeNaissance;
        private string lieuDeNaissanceArabe;
        private string adresse;
        private string adresseArabe;
        private string numInsricption;

        /// <summary>
        /// Associations
        /// </summary>
        private List<Note> notes;
        private List<AnneeScolaire> anneesScolaire;
        private List<Document> documents;

        /// <summary>
        /// Default Contructor
        /// </summary>
        /// <param name="idEtudiant"></param>
        /// <param name="nomEtudiant"></param>
        /// <param name="nomEtudiantArabe"></param>
        /// <param name="prenomEtudiant"></param>
        /// <param name="prenomEtudiantArabe"></param>
        /// <param name="cne"></param>
        /// <param name="cni"></param>
        /// <param name="massar"></param>
        /// <param name="dateDeNaissance"></param>
        /// <param name="dateInscription"></param>
        /// <param name="lieuDeNaissance"></param>
        /// <param name="lieuDeNaissanceArabe"></param>
        /// <param name="adresse"></param>
        /// <param name="adresseArabe"></param>
        /// <param name="numInsricption"></param>
        public Etudiant(int idEtudiant, string nomEtudiant, string nomEtudiantArabe, string prenomEtudiant, string prenomEtudiantArabe, string cne, string cni, string massar, 
            DateTime dateDeNaissance, DateTime dateInscription, string lieuDeNaissance, string lieuDeNaissanceArabe, string adresse, string adresseArabe, string numInsricption)
        {
            this.idEtudiant = idEtudiant;
            this.nomEtudiant = nomEtudiant;
            this.nomEtudiantArabe = nomEtudiantArabe;
            this.prenomEtudiant = prenomEtudiant;
            this.prenomEtudiantArabe = prenomEtudiantArabe;
            this.cne = cne;
            this.cni = cni;
            this.massar = massar;
            this.dateDeNaissance = dateDeNaissance;
            this.dateInscription = dateInscription;
            this.lieuDeNaissance = lieuDeNaissance;
            this.lieuDeNaissanceArabe = lieuDeNaissanceArabe;
            this.adresse = adresse;
            this.adresseArabe = adresseArabe;
            this.numInsricption = numInsricption;
        }

        /// <summary>
        /// This Contructor is made to initialize all attributes and associations
        /// </summary>
        /// <param name="idEtudiant"></param>
        /// <param name="nomEtudiant"></param>
        /// <param name="nomEtudiantArabe"></param>
        /// <param name="prenomEtudiant"></param>
        /// <param name="prenomEtudiantArabe"></param>
        /// <param name="cne"></param>
        /// <param name="cni"></param>
        /// <param name="massar"></param>
        /// <param name="dateDeNaissance"></param>
        /// <param name="dateInscription"></param>
        /// <param name="lieuDeNaissance"></param>
        /// <param name="lieuDeNaissanceArabe"></param>
        /// <param name="adresse"></param>
        /// <param name="adresseArabe"></param>
        /// <param name="numInsricption"></param>
        /// <param name="notes"></param>
        /// <param name="anneesScolaire"></param>
        /// <param name="documents"></param>
        public Etudiant(int idEtudiant, string nomEtudiant, string nomEtudiantArabe, string prenomEtudiant, string prenomEtudiantArabe, string cne, string cni, string massar, 
            DateTime dateDeNaissance, DateTime dateInscription, string lieuDeNaissance, string lieuDeNaissanceArabe, string adresse, string adresseArabe, string numInsricption, 
            List<Note> notes, List<AnneeScolaire> anneesScolaire, List<Document> documents) 
            : this (idEtudiant, nomEtudiant, nomEtudiantArabe, prenomEtudiant, prenomEtudiantArabe, cne, cni, massar, dateDeNaissance, dateInscription, lieuDeNaissance, lieuDeNaissanceArabe, adresse, adresseArabe, numInsricption)
        {
            this.notes = notes;
            this.anneesScolaire = anneesScolaire;
            this.documents = documents;
        }

        public int IdEtudiant
        {
            get { return idEtudiant; }
            set { idEtudiant = value; }
        }

        public string NomEtudiant
        {
            get { return nomEtudiant; }
            set { nomEtudiant = value; }
        }

        public string NomEtudiantArabe
        {
            get { return nomEtudiantArabe; }
            set { nomEtudiantArabe = value; }
        }

        public string PrenomEtudiant
        {
            get { return prenomEtudiant; }
            set { prenomEtudiant = value; }
        }

        public string PrenomEtudiantArabe
        {
            get { return prenomEtudiantArabe; }
            set { prenomEtudiantArabe = value; }
        }

        public string Cne
        {
            get { return cne; }
            set { cne = value; }
        }

        public string Cni
        {
            get { return cni; }
            set { cni = value; }
        }

        public string Massar
        {
            get { return massar; }
            set { massar = value; }
        }

        public DateTime DateDeNaissance
        {
            get { return dateDeNaissance; }
            set { dateDeNaissance = value; }
        }

        public DateTime DateInscription
        {
            get { return dateInscription; }
            set { dateInscription = value; }
        }

        public string LieuDeNaissance
        {
            get { return lieuDeNaissance; }
            set { lieuDeNaissance = value; }
        }

        public string LienDeNaissanceArabe
        {
            get { return lieuDeNaissanceArabe; }
            set { lieuDeNaissanceArabe = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public string AdresseArabe
        {
            get { return adresseArabe; }
            set { adresseArabe = value; }
        }

        public string NumInsricption
        {
            get { return numInsricption; }
            set { numInsricption = value; }
        }

        public List<Note> Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public List<AnneeScolaire> AnneesScolaire
        {
            get { return anneesScolaire; }
            set { anneesScolaire = value; }
        }

        public List<Document> Documents
        {
            get { return documents; }
            set { documents = value; }
        }

        public override string ToString()
        {
            return $"Id Etudiant : {idEtudiant}, Nom {NomEtudiant}, Prenom {PrenomEtudiant}, Date Naiss {DateDeNaissance.ToShortDateString()}";
        }
    }
}
