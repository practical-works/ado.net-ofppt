create database ShopKeeperDb;
use ShopKeeperDb;
create table Client (
	id int primary key,
	nom varchar(50),
	photo image
);
create table Produit (
	ref varchar(50) primary key,
	descr varchar(50),
	img image
);
create table Commande (
	id_client int foreign key references Client (id),
	ref_produit varchar(50) foreign key references Produit (ref),
	qte int
);
select * from Client;
select * from Produit;
select * from Commande;