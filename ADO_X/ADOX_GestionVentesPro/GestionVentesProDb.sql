--♦ Créer et Utiliser la base de données (GestionVentesProDb)
drop database GestionVentesProDb;
create database GestionVentesProDb; 
use GestionVentesProDb;

--♦ Créer les tables de la base de données :
--		• Table Client
create table Client (
	Id_Client int primary key identity(1,1),
	Nom varchar(50),
	Prénom varchar(50),
	Adresse varchar(100)
);
--		• Table Produit
create table Produit (
	Ref_Produit varchar(50) primary key,
	Label varchar(50),
	Quantité int,
	Seuil_Minimum int,
	Seuil_Maximum int,
	Prix_Unitaire money,
);
--		• Table ImageProduit
create table ImageProduit (
	Num_Image int primary key identity(1,1),
	Fichier image,
	Ref_Produit varchar(50) foreign key references Produit (Ref_Produit)
	on delete cascade on update cascade
);
--		• Table Commande
create table Commande (
	Ref_Commande varchar(50) primary key,
	Date_Passation date,
	État varchar(50),
	Id_Client int foreign key references Client (Id_Client)
	on delete cascade on update cascade,
);
--		• Table LigneCommande
create table LigneCommande (
	Ref_Commande varchar(50) foreign key references Commande (Ref_Commande)
	on delete cascade on update cascade,
	Ref_Produit varchar(50) foreign key references Produit (Ref_Produit)
	on delete cascade on update cascade,
	Quantité_Commandée int,
	primary key (Ref_Commande, Ref_Produit)
);
--		• Table Utilisateur
create table Utilisateur (
	Id_Utilisateur varchar(50) primary key,
	Mot_Passe varchar(50),
	Rôle varchar(50),
	Date_Dernière_Connexion datetime
);

--♦ Insérer des données de test dans les tables
insert into ImageProduit values
(null, null);

--♦ Requêtes de sélection
declare @id varchar(max) = 'admin', @pass varchar(max) = '123';
select * from Utilisateur where Id_Utilisateur=@id and Mot_Passe=@pass;
select * from Produit;
select * from ImageProduit;

--♦ Requêtes de mise à jour
insert into ImageProduit values (null, 1);
delete from Produit;
delete from ImageProduit where Ref_Produit = '545';

--♦ ...