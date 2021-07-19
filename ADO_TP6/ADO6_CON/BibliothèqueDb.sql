create database BibliothequeDb;
use BibliothequeDb;
create table Adherent (
	CODADH int primary key identity(1,1),
	NOMADH varchar(30),
	ADRADH varchar(300),
	TYPADH varchar(30),
	CINADH varchar(30),
	DNADH date
);
create table Ouvrage (
	CODOUV int primary key,
	TITOUV varchar(30),
	NOMAUT varchar(30),
	TYPOUV varchar(30), --(livre, roman)
	DATEDIT date,
	DATACH date,
	NBPAGE int
);
create table Emprunt (
	NUMEMP int primary key,
	CODADH int foreign key references Adherent (CODADH)
	on delete set null on update cascade,
	CODOUV int foreign key references Ouvrage (CODOUV)
	on delete set null on update cascade,
	DATEMP date,
	DATRET date
);
select * from Adherent;
select * from Ouvrage;
select * from Emprunt;

select * from Ouvrage where CODOUV not in (select CODOUV from Emprunt where DATRET is not null);