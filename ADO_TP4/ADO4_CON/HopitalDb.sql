create database HopitalDb;
use HopitalDb;

create table Medecin (
	code_medecin int primary key,
	nom_medecin varchar(30),
	tel_medecin varchar(10),
	date_embauche date,
	specialite_medecin varchar(30)
);
create table RDV (
	num_rdv int primary key,
	date_rdv date,
	heure_rdv varchar(5),
	code_patient int,
	code_medecin int
);
create table Patient (
	code_patient int primary key,
	nom_patient varchar(30),
	adresse_patient varchar(60),
	date_naissance date,
	sexe_patient varchar(1)
);

alter table Medecin 
add constraint c_tel check(tel_medecin like '06________');
alter table Medecin
add constraint c_dateEmb check(date_embauche <= GetDate());

alter table patient
add constraint c_dateNaiss check(date_naissance <= GetDate());
alter table patient
add constraint c_sexe check(sexe_patient in ('M','F'));

alter table RDV
add constraint c_dateRDV check(date_rdv >= GetDate());
alter table RDV
add constraint c_heure check(heure_rdv like '__:__');
alter table RDV
add constraint fk_patient foreign key(code_patient) references Patient(code_patient);
alter table RDV
add constraint fk_medecin foreign key(code_medecin) references Medecin(code_medecin);

INSERT INTO Patient VALUES
(1,'Kyle Blake','954 Arcu. Avenue','1987-11-27','F'),
(2,'Virginia Gillespie','Ap #833-7742 Et Rd.','1990-02-06','M'),
(3,'Mira Weeks','Ap #936-5445 Laoreet Av.','1984-10-26','F'),
(4,'Azalia Chang','737-6129 Mi Rd.','1982-09-12','M'),
(5,'Quinn Howell','277-6565 Vel St.','1990-03-24','F'),
(6,'Cheyenne Martinez','P.O. Box 386, 1078 Faucibus Avenue','1987-11-01','M'),
(7,'Rebecca Kidd','6920 Scelerisque Street','1987-10-14','F'),
(8,'Maxine Klein','P.O. Box 783, 1835 Massa. Rd.','1988-12-15','M'),
(9,'Velma Rivers','P.O. Box 169, 2151 Ligula Rd.','1982-11-12','F'),
(10,'Gabriel Snider','P.O. Box 247, 7629 Gravida Av.','1983-04-16','F'),
(11,'Kathleen Gross','398-3152 Pede, Av.','1981-12-17','M'),
(12,'Kessie Baird','987-8355 Aliquam Avenue','1983-11-27','F'),
(13,'Trevor Maddox','P.O. Box 266, 3767 Integer Street','1985-07-04','F'),
(14,'Berk Goff','Ap #597-7156 Vel Ave','1980-10-24','F'),
(15,'Garrison Chambers','Ap #512-1782 Congue Ave','1985-10-19','M'),
(16,'Keaton Phelps','P.O. Box 610, 3401 Nibh St.','1989-01-13','M'),
(17,'Diana Higgins','Ap #554-4581 Dictum Rd.','1982-06-23','M'),
(18,'Mufutau Schneider','P.O. Box 291, 183 Et, Avenue','1990-07-05','F'),
(19,'Madaline Chambers','P.O. Box 762, 7826 Risus. Road','1990-06-26','F'),
(20,'Roary Jefferson','2694 Libero St.','1989-12-21','M');
