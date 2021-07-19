create database AbonnementDb;
use AbonnementDb;
create table Abonne (
	CodeAbo int primary key,
	Nom varchar(30),
	Adresse varchar(100),
	Tel varchar(20)
);
create table Produit (
	ref int primary key,
	Libelle varchar(30),
	Prix float
);
create table Contrat (
	CodeCon int primary key,
	CodeAbo int foreign key references Abonne (CodeAbo),
	Ref int foreign key references Produit (Ref),
	Qte int,
	DateCon date
);
