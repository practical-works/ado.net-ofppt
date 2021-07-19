create database ProjetsDb;
use ProjetsDb;
create table Employe (
	NumEmp int primary key, 
	Nom varchar(50), 
	Prenom varchar(50), 
	Sexe varchar(1) check (Sexe in ('M','F')),
	DNaiss date, 
	Fonction varchar(50)
);
create table TypeProjet (
	TypeProjet int primary key, 
	Libelle varchar(50), 
	Duree int
);
create table Projet (
	CodeProjet int primary key, 
	TypeProjet int foreign key references TypeProjet (TypeProjet), 
	DateDebut date, 
	DateFin date
);
create table Inscription (
	NumEmp int foreign key references Employe (NumEmp), 
	CodeProjet int foreign key references Projet (CodeProjet), 
	DateInscription date,
	primary key (NumEmp, CodeProjet)
);

delete from Employe;
INSERT INTO Employe VALUES (1, 'terrell', 'harvey', 'M', '19861109', 'Cursus.');
INSERT INTO Employe VALUES (2, 'watkins', 'camille', 'F', '20110515', 'Hendrerit.');
INSERT INTO Employe VALUES (3, 'hernandez', 'phoebe', 'M', '20090702', 'Vel.');
INSERT INTO Employe VALUES (4, 'garza', 'kaia', 'M', '20120926', 'Risus!');
INSERT INTO Employe VALUES (5, 'livingston', 'kristopher', 'F', '19920624', 'Aptent.');
INSERT INTO Employe VALUES (6, 'espinoza', 'braiden', 'F', '19900702', 'Posuere.');
INSERT INTO Employe VALUES (7, 'carver', 'clay', 'M', '20090905', 'Vestibulum.');
INSERT INTO Employe VALUES (8, 'cunningham', 'chance', 'M', '19911024', 'Feugiat.');
INSERT INTO Employe VALUES (9, 'huffman', 'graham', 'M', '19900228', 'Id.');
INSERT INTO Employe VALUES (10, 'church', 'tristian', 'F', '20070622', 'Imperdiet.');
INSERT INTO Employe VALUES (11, 'garrett', 'lydia', 'F', '19980401', 'Lectus.');
INSERT INTO Employe VALUES (12, 'watson', 'xavi', 'M', '19900714', 'Amet.');
INSERT INTO Employe VALUES (13, 'sweet', 'gisselle', 'M', '19930819', 'Malesuada.');
INSERT INTO Employe VALUES (14, 'fletcher', 'daxton', 'M', '19900512', 'Penatibus.');
INSERT INTO Employe VALUES (15, 'taylor', 'ella', 'F', '20130218', 'Leo.');
INSERT INTO Employe VALUES (16, 'dixon', 'ross', 'M', '19830520', 'Natoque.');
INSERT INTO Employe VALUES (17, 'fields', 'kinley', 'M', '20090803', 'Platea.');
INSERT INTO Employe VALUES (18, 'jones', 'zion', 'F', '19931014', 'Cras.');
INSERT INTO Employe VALUES (19, 'vaughn', 'virginia', 'F', '19970430', 'Justo.');
INSERT INTO Employe VALUES (20, 'hunter', 'gracelyn', 'M', '20040624', 'Purus.');

delete from Projet;
INSERT INTO Projet VALUES (1, 2, '20161119', '20161108');
INSERT INTO Projet VALUES (2, 1, '20161030', '20161125');
INSERT INTO Projet VALUES (3, 2, '20161110', '20161128');
INSERT INTO Projet VALUES (4, 2, '20161025', '20161030');
INSERT INTO Projet VALUES (5, 2, '20161026', '20161105');

delete from TypeProjet;
INSERT INTO TypeProjet VALUES (1, 'Ad.', 1707);
INSERT INTO TypeProjet VALUES (2, 'Risus.', 1566);
INSERT INTO TypeProjet VALUES (3, 'Malesuada.', 570);

delete from Inscription;
INSERT INTO Inscription VALUES (18, 2, '20160711');
INSERT INTO Inscription VALUES (16, 2, '20160205');
INSERT INTO Inscription VALUES (18, 4, '20150315');
INSERT INTO Inscription VALUES (8, 4, '20150213');
INSERT INTO Inscription VALUES (7, 3, '20150301');
INSERT INTO Inscription VALUES (2, 4, '20160401');
INSERT INTO Inscription VALUES (7, 4, '20150113');
INSERT INTO Inscription VALUES (20, 3, '20160224');
INSERT INTO Inscription VALUES (2, 3, '20160212');
INSERT INTO Inscription VALUES (16, 4, '20150502');

select * from Employe;
select * from Projet;
select * from TypeProjet;
select * from Inscription;