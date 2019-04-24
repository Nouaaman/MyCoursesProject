use MyCourses

insert into Annee values
(1, '1er année'),
(2, '2éme année')

select * from Annee


insert into Filiere values
(1,'base de donnée'),
(2,'Gestion'),
(3,'Web master')

select * from Filiere

insert into Etudiant 
values
(1,'nom1','prenom1','email1.@email.com','motdepasse1',1,1,null),
(2,'nom2','prenom2','email2.@email.com','motdepasse2',2,1,null),
(3,'nom3','prenom3','email3.@email.com','motdepasse3',1,2,null)

select * from Etudiant

insert into Administrateur
values('nom1','prenom1','email@email.com','motdepasse',1)


Declare @idE int, @idA int
select @idE=3, @idA=1
exec SupprimerEtudiant @idE, @idA

select * from ArchiveEtudiant

--delete from Annee where Id >=0
--GO
--delete from Filiere where Id >=0
--GO
--drop table Annee
--GO
--drop table Filiere
