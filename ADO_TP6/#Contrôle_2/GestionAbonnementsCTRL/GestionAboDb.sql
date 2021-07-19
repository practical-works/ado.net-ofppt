create database GestionAboDb;
use GestionAboDb;
create table Abonne (
	ID int primary key,
	Nom varchar(50),
	Tel varchar(50)
);
create table Abonnement (
	ID int primary key,
	DateAbn date,
	IDAbonne int foreign key references Abonne (ID)
);
create table Consommation (
	ID int primary key,
	Periode date,
	Qte int,
	IDAbonnement int foreign key references Abonnement (ID),
);

select Abonnement.ID, Abonne.Nom, sum(Qte) as 'Somme Consommations'
from Consommation 
inner join Abonnement on Abonnement.ID = Consommation.IDAbonnement
inner join Abonne on Abonne.ID = Abonnement.IDAbonne
group by Abonnement.ID, Abonne.Nom;
 
select Abonnement.ID, Abonne.Nom
from Consommation 
inner join Abonnement on Abonnement.ID = Consommation.IDAbonnement
inner join Abonne on Abonne.ID = Abonnement.IDAbonne
group by Abonnement.ID, Abonne.Nom;
