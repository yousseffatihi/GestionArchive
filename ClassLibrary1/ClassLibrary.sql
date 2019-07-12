CREATE TABLE Etudiant (
  IdEtudiant           int IDENTITY NOT NULL, 
  NomEtudiant          varchar(255) NULL, 
  NomEtudiantArabe     varchar(255) NULL, 
  PrenomEtudiant       varchar(255) NULL, 
  PrenomEtudiantArabe  varchar(255) NULL, 
  Cne                  varchar(255) NULL, 
  Cni                  varchar(255) NULL, 
  Massar               varchar(255) NULL, 
  DateDeNaissance      datetime NULL, 
  DateInscription      datetime NULL, 
  LieuDeNaissance      varchar(255) NULL, 
  LienDeNaissanceArabe varchar(255) NULL, 
  Adresse              varchar(255) NULL, 
  AdresseArabe         varchar(255) NULL, 
  NumInsricption       varchar(255) NULL, 
  PRIMARY KEY (IdEtudiant));
CREATE TABLE Classe (
  IdClasse     int IDENTITY NOT NULL, 
  NomClasse    varchar(255) NULL, 
  NiveauClasse varchar(255) NULL, 
  PRIMARY KEY (IdClasse));
CREATE TABLE Document (
  IdDocument   int IDENTITY NOT NULL, 
  FichPath     varchar(255) NULL, 
  TypeDocument varchar(255) NULL, 
  IdEtudiant   int NOT NULL, 
  PRIMARY KEY (IdDocument));
CREATE TABLE Note (
  IdNote      int IDENTITY NOT NULL, 
  NomMatiere  varchar(255) NULL, 
  NoteMatiere float(10) NOT NULL, 
  CoefMatiere int NOT NULL, 
  IdClasse    int NOT NULL, 
  IdEtudiant  int NOT NULL, 
  PRIMARY KEY (IdNote));
CREATE TABLE AnneeScolaire (
  IdAnneeScolaire int IDENTITY NOT NULL, 
  AnneeScolaire   varchar(255) NULL, 
  IdClasse        int NOT NULL, 
  IdEtudiant      int NOT NULL, 
  PRIMARY KEY (IdAnneeScolaire));
ALTER TABLE Document ADD CONSTRAINT Extraire FOREIGN KEY (IdEtudiant) REFERENCES Etudiant (IdEtudiant);
ALTER TABLE Note ADD CONSTRAINT Avoir FOREIGN KEY (IdEtudiant) REFERENCES Etudiant (IdEtudiant);
ALTER TABLE Note ADD CONSTRAINT Comporter FOREIGN KEY (IdClasse) REFERENCES Classe (IdClasse);
ALTER TABLE AnneeScolaire ADD CONSTRAINT Etudier FOREIGN KEY (IdEtudiant) REFERENCES Etudiant (IdEtudiant);
ALTER TABLE AnneeScolaire ADD CONSTRAINT Durer FOREIGN KEY (IdClasse) REFERENCES Classe (IdClasse);
