--CREATE DATABASE MyCourses
--drop database MyCourses
GO
USE MyCourses
GO

-- tables 
GO
CREATE TABLE Annee(
	id INT PRIMARY KEY NOT NULL ,
	titre VARCHAR(30) NOT NULL
)

GO

CREATE TABLE Filiere(
	id INT PRIMARY KEY NOT NULL,
	titre VARCHAR(30) NOT NULL,
)

GO


CREATE TABLE Etudiant(
	id INT PRIMARY KEY NOT NULL,
	nom VARCHAR(30) NOT NULL,
	prenom VARCHAR(30) NOT NULL,
	email VARCHAR(MAX) NOT NULL,
	mot_de_passe VARCHAR(100) NOT NULL,
	id_filiere INT FOREIGN KEY REFERENCES Filiere(id) NOT NULL,
	id_annee INT FOREIGN KEY REFERENCES Annee(id) NOT NULL,
	derniere_connexion DATETIME 
)

GO
CREATE TABLE Professeur(
	id INT PRIMARY KEY NOT NULL,
	nom VARCHAR(30) NOT NULL,
	prenom VARCHAR(30) NOT NULL,
	email VARCHAR(MAX) NOT NULL,
	mot_de_passe VARCHAR(100) NOT NULL,
	id_filiere INT FOREIGN KEY REFERENCES Filiere(id) NOT NULL,
	derniere_connexion DATETIME 
)

GO

CREATE TABLE Cour(	
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	module NVARCHAR(100) NOT NULL,
	fichier VARBINARY(MAX) NOT NULL,
	nom_fichier NVARCHAR(100) NOT NULL,
	type_fichier VARCHAR(6) NOT NULL,
	id_prof INT FOREIGN KEY REFERENCES Professeur(id) NOT NULL,
	id_filiere INT FOREIGN KEY REFERENCES Filiere(id) NOT NULL,
	id_annee INT FOREIGN KEY REFERENCES Annee(id) NOT NULL
)

GO 


CREATE TABLE Administrateur(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nom VARCHAR(30) NOT NULL,
	prenom VARCHAR(30) NOT NULL,
	email VARCHAR(MAX) NOT NULL,
	mot_de_passe VARCHAR(100) NOT NULL,
	permission_total INT NOT NULL, -- oui = 1,non = 0 
)

GO
-- archive
CREATE TABLE Archive_Etudiant(
	id INT PRIMARY KEY NOT NULL,
	nom VARCHAR(30) NOT NULL,
	prenom VARCHAR(30) NOT NULL,
	email VARCHAR(MAX) NOT NULL,
	mot_de_passe VARCHAR(100) NOT NULL,
	id_filiere INT NOT NULL,
	id_annee INT NOT NULL,
	supprime_par VARCHAR(100) NOT NULL,
	date_suppression DATETIME
)

GO

CREATE TABLE Archive_Professeur(
	id INT PRIMARY KEY NOT NULL,
	nom VARCHAR(30) NOT NULL,
	prenom VARCHAR(30) NOT NULL,
	email VARCHAR(MAX) NOT NULL,
	mot_de_passe VARCHAR(30) NOT NULL,
	id_filiere INT NOT NULL,
	supprime_par VARCHAR(100) NOT NULL,
	date_suppression DATETIME
)


/****************************************************************************************
									PROCEDURES	
****************************************************************************************/

----------------------------------ADMINISTATEUR------------------------------------------

--Ajouter administrateur
GO
CREATE PROCEDURE AjouterAdmin 
	@Nom VARCHAR(30),
	@Prenom VARCHAR(30),
	@Email VARCHAR(MAX),
	@MotDePasse VARCHAR(100),
	@PermissionTotal INT
AS
BEGIN
	INSERT INTO Administrateur 
	VALUES (@Nom, @Prenom, @Email, @MotDePasse, @PermissionTotal)
END


--Supprimer administrateur
GO
CREATE PROCEDURE SupprimerAdmin 
	@Id INT
AS	
BEGIN
	DELETE FROM Administrateur WHERE id = @Id
END

----------------------------------PROFESSEUR------------------------------------------

--Ajouter Professeur
GO
CREATE PROCEDURE AjouterProfesseur 
	@Id INT,
	@Nom VARCHAR(30),
	@Prenom VARCHAR(30),
	@Email VARCHAR(MAX),
	@MotDePasse VARCHAR(100),
	@IdFiliere INT
AS
BEGIN
	INSERT INTO Professeur
	VALUES (@Id, @Nom, @Prenom, @Email, @MotDePasse, @IdFiliere)
END

--Supprimer Professeur
GO
CREATE PROCEDURE SupprimerProfesseur 
	@IdProf INT,
	@IdAdmin INT
AS	
BEGIN
	DECLARE @Id INT,
			@Nom VARCHAR(30),
			@Prenom VARCHAR(30),
			@Email VARCHAR(MAX),
			@MotDePasse VARCHAR(100),
			@IdFiliere INT,
			@SupprimePar VARCHAR(100),
			@DateSuppression DATETIME

	SELECT @SupprimePar = CONCAT(nom,' ',prenom) FROM Administrateur WHERE id = @IdAdmin
	SELECT @DateSuppression = GETDATE()
	
	--recuperer les donnees
	SELECT @Id=id, @Nom=nom, @Prenom=prenom, @Email=email, @MotDePasse=mot_de_passe,@IdFiliere=id_filiere
	FROM Professeur
	WHERE id = @IdProf

	--archiver
	INSERT INTO Archive_Professeur
	VALUES(@IdProf,@Nom, @Prenom, @Email, @MotDePasse,@IdFiliere,@SupprimePar,@DateSuppression)

	--supprimer
	DELETE FROM Professeur WHERE id = @IdProf
END

----------------------------------ETUDIANT------------------------------------------

--Ajouter Etudiant

GO
CREATE PROCEDURE AjouterEtudiant 
	@Id INT,
	@Nom VARCHAR(30),
	@Prenom VARCHAR(30),
	@Email VARCHAR(MAX),
	@MotDePasse VARCHAR(100),
	@Filiere INT,
	@Annee INT
AS
BEGIN
	INSERT INTO Etudiant
	VALUES (@Id, @Nom, @Prenom, @Email, @MotDePasse, @Filiere,@Annee)
END

--Supprimer Etudiant

GO
CREATE PROCEDURE SupprimerEtudiant
	@IdEtud int,
	@IdAdmin int
AS	
BEGIN
	DECLARE @Id int,
			@Nom varchar(30),
			@Prenom varchar(30),
			@Email varchar(max),
			@MotDePasse varchar(100),
			@Filiere int,
			@Annee int,
			@SupprimePar varchar(100),
			@DateSuppression DATETIME

	SELECT @SupprimePar = CONCAT(nom,' ',prenom) FROM Administrateur WHERE id = @IdAdmin
	SELECT @DateSuppression = GETDATE()
	
	--recuperer les donnees
	SELECT @Id=id, @Nom=nom, @Prenom=prenom, @Email=email, @MotDePasse=mot_de_passe,@Filiere=id_filiere,@Annee=id_annee
	FROM Etudiant
	WHERE id = @IdEtud

	--archiver
	INSERT INTO Archive_Etudiant
	VALUES(@IdEtud,@Nom, @Prenom, @Email, @MotDePasse,@Filiere,@Annee,@SupprimePar,@DateSuppression)

	--supprimer
	DELETE FROM Etudiant WHERE id = @IdEtud
END


----------------------------------COURS------------------------------------------

--ajouter cour
GO
CREATE PROCEDURE AjouterCour 
	@Id INT,
	@Module NVARCHAR(100),
	@Fichier VARBINARY(MAX),
	@NomFichier NVARCHAR(100),
	@TypeFichier VARCHAR(6),
	@IdProf INT,
	@IdFiliere INT,
	@idAnnee INT
AS
BEGIN
	INSERT INTO Cour
	VALUES (@Id, @Module, @Fichier, @NomFichier, @TypeFichier, @IdProf, @IdFiliere, @idAnnee)
END

--Supprimer Cour
GO
CREATE PROCEDURE SupprimerCour
	@Id INT
AS	
BEGIN
	DELETE FROM Cour WHERE id = @Id
END

----------------------------------Filiere------------------------------------------

--ajouter filiere
GO
CREATE PROCEDURE AjouterFiliere
	@Id INT,
	@Titre VARCHAR(30),
	@Annee INT
AS
BEGIN
	INSERT INTO Filiere
	VALUES (@Id, @Titre, @Annee)
END

--Supprimer filiere
GO
CREATE PROCEDURE SupprimerFiliere
	@Id int
AS	
BEGIN
	DELETE FROM Filiere WHERE id = @Id
END

----------------------------------ANNEE------------------------------------------

--ajouter Annee
GO
CREATE PROCEDURE AjouterAnnee
	@Id INT,
	@Titre VARCHAR(30)
AS
BEGIN
	INSERT INTO Annee
	VALUES (@Id, @Titre)
END

--Supprimer Annee
GO
CREATE PROCEDURE SupprimerAnnee
	@Id int
AS	
BEGIN
	DELETE FROM Annee WHERE id = @Id
END

--dbcc checkident('TableName',reseed,0); pour renitialiser identity
