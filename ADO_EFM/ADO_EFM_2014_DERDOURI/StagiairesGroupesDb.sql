create database StagiairesGroupesDb;
use StagiairesGroupesDb;
create table Groupes (
	Code int primary key,
	Filière varchar(10),
	Année int,
	Responsable int
);
create table Stagiaires (
	Numéro int primary key,
	Nom varchar(50),
	Prénom varchar(50),
	Sexe varchar(1),
	DateNaissance date,
	Groupe int
);
alter table Groupes
add foreign key (Responsable) references Stagiaires (Numéro);
alter table Stagiaires
add foreign key (Groupe) references Groupes (Code);

select * from Groupes;
select * from Stagiaires where Groupe = 1;

select Code, count(*) as 'Nombre de stagiaires'
from Groupes G inner join Stagiaires S
on G.Code = S.Groupe
group by Code;