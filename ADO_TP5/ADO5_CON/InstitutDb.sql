create database InstitutDb;
use InstitutDb;
create table Module (
	num_mod int primary key,
	nom_mod varchar(30)
);
create table Stagiaire (
	num_sta int primary key,
	nom_sta varchar(30),
	pre_sta varchar(30),
	date_sta date
);
create table Note (
	num_sta int,
	num_mod int,
	note float
);
alter table Note add constraint fk_stagiaire
foreign key(num_sta) references Stagiaire(num_sta);
alter table Note add constraint fk_module
foreign key(num_mod) references Module(num_mod);

alter table Note add constraint c_note
check( note between 0 and 20 );
alter table Stagiaire add constraint c_date
check( date_sta <= GetDate() );

select avg(note) from note where num_sta=1;

select * from Stagiaire where nom_sta='El madani' and pre_sta='Salim';

select Module.num_mod,nom_mod,note 
from module inner join note
on Module.num_mod = Note.num_mod
where note.num_sta = 1;