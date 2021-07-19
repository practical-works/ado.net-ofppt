create database StagiairesGroupesDb;
use StagiairesGroupesDb;
create table Groupes (
	Code int primary key,
	Fili�re varchar(10),
	Ann�e int,
	Responsable int
);
create table Stagiaires (
	Num�ro int primary key,
	Nom varchar(50),
	Pr�nom varchar(50),
	Sexe varchar(1),
	DateNaissance date,
	Groupe int
);
alter table Groupes
add foreign key (Responsable) references Stagiaires (Num�ro);
alter table Stagiaires
add foreign key (Groupe) references Groupes (Code);

select * from Groupes;
select * from Stagiaires where Groupe = 1;

select Code, count(*) as 'Nombre de stagiaires'
from Groupes G inner join Stagiaires S
on G.Code = S.Groupe
group by Code;