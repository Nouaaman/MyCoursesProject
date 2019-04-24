CREATE DATABASE MyCourses
go
USE MyCourses
go

-- tables 
GO
CREATE TABLE Annee(
	Id INT PRIMARY KEY NOT NULL ,
	Titre VARCHAR(30) NOT NULL
)

go

CREATE TABLE Filiere(
	Id INT PRIMARY KEY NOT NULL,
	Titre VARCHAR(30) NOT NULL,
)

go


CREATE TABLE Etudiant(
	Id INT PRIMARY KEY NOT NULL,
	Nom varchar(30) not null,
	Prenom varchar(30) not null,
	Email varchar(max) not null,
	MotDePasse varchar(100) not null,
	Filiere int foreign key references Filiere(Id) not null,
	Annee int foreign key references Annee(Id) not null,
	DerniereConnexion datetime 
)

go
CREATE TABLE Professeur(
	Id int primary key not null,
	Nom varchar(30) not null,
	Prenom varchar(30) not null,
	Email varchar(max) not null,
	MotDePasse varchar(100) not null,
	Filiere int foreign key references Filiere(Id) not null,
	DerniereConnexion datetime 
)

go

CREATE TABLE Cour(	
	Id int identity(1,1) primary key not null,
	Module nvarchar(100) not null,
	Fichier varbinary(max) not null,
	NomFichier nvarchar(100) not null,
	TypeFichier varchar(6) not null,
	IdProf int foreign key references Professeur(Id) not null,
	IdFiliere int foreign key references Filiere(Id) not null,
	idAnnee int foreign key references Annee(Id) not null
)

go 


CREATE TABLE Administrateur(
	Id int identity(1,1) primary key not null,
	Nom varchar(30) not null,
	Prenom varchar(30) not null,
	Email varchar(max) not null,
	MotDePasse varchar(100) not null,
	PermissionTotal int not null,
)

Go
-- archive
CREATE TABLE ArchiveEtudiant(
	Id int primary key not null,
	Nom varchar(30) not null,
	Prenom varchar(30) not null,
	Email varchar(max) not null,
	MotDePasse varchar(100) not null,
	Filiere int not null,
	Annee int not null,
	SupprimePar varchar(100) NOT NULL,
	DateSuppression datetime
)

GO

CREATE TABLE ArchiveProfesseur(
	Id int primary key not null,
	Nom varchar(30) not null,
	Prenom varchar(30) not null,
	Email varchar(max) not null,
	MotDePasse varchar(30) not null,
	Filiere int not null,
	SupprimePar varchar(100) NOT NULL,
	DateSuppression datetime
)


/****************************************************************************************
									PROCEDURES	
****************************************************************************************/

----------------------------------ADMINISTATEUR------------------------------------------

--Ajouter administrateur
GO
CREATE PROCEDURE AjouterAdmin 
	@Nom varchar(30),
	@Prenom varchar(30),
	@Email varchar(max),
	@MotDePasse varchar(100),
	@PermissionTotal int
AS
BEGIN
	INSERT INTO Administrateur 
	VALUES (@Nom, @Prenom, @Email, @MotDePasse, @PermissionTotal)
END


--Supprimer administrateur
GO
CREATE PROCEDURE SupprimerAdmin 
	@Id int
AS	
BEGIN
	DELETE FROM Administrateur WHERE Id = @Id
END

----------------------------------PROFESSEUR------------------------------------------

--Ajouter Professeur
GO
CREATE PROCEDURE AjouterProfesseur 
	@Id int,
	@Nom varchar(30),
	@Prenom varchar(30),
	@Email varchar(max),
	@MotDePasse varchar(100),
	@Filiere int
AS
BEGIN
	INSERT INTO Professeur
	VALUES (@Id, @Nom, @Prenom, @Email, @MotDePasse, @Filiere)
END

--Supprimer Professeur
GO
CREATE PROCEDURE SupprimerProfesseur 
	@IdP int,
	@IdA int
AS	
BEGIN
	DECLARE @Id int,
			@Nom varchar(30),
			@Prenom varchar(30),
			@Email varchar(max),
			@MotDePasse varchar(100),
			@Filiere int,
			@SupprimePar varchar(100),
			@DateSuppression DATETIME

	SELECT @SupprimePar = CONCAT(Nom,' ',Prenom) FROM Administrateur WHERE Id = @IdA
	SELECT @DateSuppression = GETDATE()
	
	--recuperer les donnees
	SELECT @Id=Id, @Nom=Nom, @Prenom=Prenom, @Email=Email, @MotDePasse=MotDePasse,@Filiere=Filiere
	FROM Professeur
	WHERE Id = @IdP

	--archiver
	INSERT INTO ArchiveProfesseur
	VALUES(@IdP,@Nom, @Prenom, @Email, @MotDePasse,@Filiere,@SupprimePar,@DateSuppression)

	--supprimer
	DELETE FROM Professeur WHERE Id = @IdP
END

----------------------------------ETUDIANT------------------------------------------

--Ajouter Etudiant
GO
CREATE PROCEDURE AjouterEtudiant 
	@Id int,
	@Nom varchar(30),
	@Prenom varchar(30),
	@Email varchar(max),
	@MotDePasse varchar(100),
	@Filiere int,
	@Annee int
AS
BEGIN
	INSERT INTO Etudiant
	VALUES (@Id, @Nom, @Prenom, @Email, @MotDePasse, @Filiere,@Annee)
END

--Supprimer Etudiant
GO
CREATE PROCEDURE SupprimerEtudiant
	@IdE int,
	@IdA int
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

	SELECT @SupprimePar = CONCAT(Nom,' ',Prenom) FROM Administrateur WHERE Id = @IdA
	SELECT @DateSuppression = GETDATE()
	
	--recuperer les donnees
	SELECT @Id=Id, @Nom=Nom, @Prenom=Prenom, @Email=Email, @MotDePasse=MotDePasse,@Filiere=Filiere,@Annee=Annee
	FROM Etudiant
	WHERE Id = @IdE

	--archiver
	INSERT INTO ArchiveEtudiant
	VALUES(@IdE,@Nom, @Prenom, @Email, @MotDePasse,@Filiere,@Annee,@SupprimePar,@DateSuppression)

	--supprimer
	DELETE FROM Etudiant WHERE Id = @IdE
END


----------------------------------COURS------------------------------------------

--ajouter cour
GO
CREATE PROCEDURE AjouterCour 
	@Id int,
	@Module nvarchar(100),
	@Fichier varbinary(max),
	@NomFichier nvarchar(100),
	@TypeFichier varchar(6),
	@IdProf int,
	@IdFiliere int,
	@idAnnee int
AS
BEGIN
	INSERT INTO Etudiant
	VALUES (@Id, @Module, @Fichier, @NomFichier, @TypeFichier, @IdProf, @IdFiliere, @idAnnee)
END

--Supprimer Cour
GO
CREATE PROCEDURE SupprimerEtudiant
	@Id int
AS	
BEGIN
	DELETE FROM Etudiant WHERE Id = @Id
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
	DELETE FROM Filiere WHERE Id = @Id
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
	DELETE FROM Annee WHERE Id = @Id
END

--dbcc checkident('TableName',reseed,0); pour renitialiser identity