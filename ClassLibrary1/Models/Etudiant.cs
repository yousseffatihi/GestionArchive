using System;
using System.Collections.Generic;

namespace Models {
	public class Etudiant {
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
        private string lienDeNaissanceArabe;
        private string adresse;
        private string adresseArabe;
        private string numInsricption;

        private System.Collections.Generic.List<Note> notes;
        private System.Collections.Generic.List<AnneeScolaire> anneesScolaire;

        private System.Collections.Generic.List<Document> documents;

        public Etudiant(int idEtudiant, string nomEtudiant, string nomEtudiantArabe, string prenomEtudiant, string prenomEtudiantArabe, string cne, string cni, string massar, DateTime dateDeNaissance, DateTime dateInscription, string lieuDeNaissance, string lienDeNaissanceArabe, string adresse, string adresseArabe, string numInsricption)
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
            this.lienDeNaissanceArabe = lienDeNaissanceArabe;
            this.adresse = adresse;
            this.adresseArabe = adresseArabe;
            this.numInsricption = numInsricption;
        }

        public Etudiant(int idEtudiant, string nomEtudiant, string nomEtudiantArabe, string prenomEtudiant, string prenomEtudiantArabe, string cne, string cni, string massar, DateTime dateDeNaissance, DateTime dateInscription, string lieuDeNaissance, string lienDeNaissanceArabe, string adresse, string adresseArabe, string numInsricption, List<Note> notes, List<AnneeScolaire> anneesScolaire, List<Document> documents)
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
            this.lienDeNaissanceArabe = lienDeNaissanceArabe;
            this.adresse = adresse;
            this.adresseArabe = adresseArabe;
            this.numInsricption = numInsricption;
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
            get { return lienDeNaissanceArabe; }
            set { lienDeNaissanceArabe = value; }
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
    }

}
