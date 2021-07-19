create database GestionMagasinDb;
use GestionMagasinDb;
CREATE TABLE Categorie (
	ID_Categorie int primary key IDENTITY(1,1),
	Description_Categorie varchar(50)
);
CREATE TABLE Produit (
	Ref_Produit varchar(50) primary key,
	Label_Produit varchar(50),
	Quantite_Stock int NOT NULL,
	Prix_Produit money NOT NULL,
	Image_Produit image,
	ID_Categorie int foreign key references Categorie (ID_Categorie)
	on delete cascade on update cascade
);
CREATE TABLE Client (
	ID_Client int primary key IDENTITY(1,1),
	Nom_Client varchar(50) NOT NULL,
	Prenom_Client varchar(50) NOT NULL,
	Telephone_Client varchar(50),
	Email_Client varchar(50),
	Photo_Client varbinary(max)
);

CREATE TABLE Commande (
	ID_Commande int primary key,
	ID_Client int foreign key references Client (ID_Client)
	on delete cascade on update cascade,
	Date_Commande date
);
CREATE TABLE LigneCommande (
	ID_Commande int foreign key references Commande (ID_Commande)
	on delete cascade on update cascade,
	Ref_Produit varchar(50) foreign key references Produit (Ref_Produit)
	on delete cascade on update cascade,
	Quantite_Produit int NOT NULL,
);

alter table LigneCommande

create view V as
select Commande.ID_Commande, Commande.Date_Commande, Client.Nom_Client, Client.Telephone_Client, Client.Photo_Client,
Produit.Ref_Produit, Produit.Prix_Produit, LigneCommande.Quantite_Produit, 
sum(Produit.Prix_Produit*LigneCommande.Quantite_Produit) as 'Prix_Total'
from LigneCommande
inner join Commande on Commande.ID_Commande = LigneCommande.ID_Commande
inner join Produit on Produit.Ref_Produit = LigneCommande.Ref_Produit
inner join Client on Client.ID_Client = Commande.ID_Client
group by Commande.ID_Commande, Commande.Date_Commande, Client.Nom_Client, Client.Telephone_Client, Client.Photo_Client,
Produit.Ref_Produit, Produit.Prix_Produit, LigneCommande.Quantite_Produit;

select * from V where ID_Commande = 1;
select sum(Prix_Total) from V;


