using System;
using System.Collections.Generic;

namespace Models {
	public class Document {
		private int idDocument;
		private System.Collections.Generic.List<string> fichPath;
		private System.Collections.Generic.List<string> typeDocument;

		private Etudiant etudiant;

        public Document(int idDocument)
        {
            this.idDocument = idDocument;
        }

        public Document(int idDocument, List<string> fichPath, List<string> typeDocument, Etudiant etudiant)
        {
            this.idDocument = idDocument;
            this.fichPath = fichPath;
            this.typeDocument = typeDocument;
            this.etudiant = etudiant;
        }

        public int IdDocument
        {
            get { return idDocument; }
            set { idDocument = value; }
        }

        public List<string> FichPath
        {
            get { return fichPath; }
            set { fichPath = value; }
        }

        public List<string> TypeDocument
        {
            get { return typeDocument; }
            set { typeDocument = value; }
        }

        public Etudiant Etudiant
        {
            get { return etudiant; }
            set { etudiant = value; }
        }
    }

}
