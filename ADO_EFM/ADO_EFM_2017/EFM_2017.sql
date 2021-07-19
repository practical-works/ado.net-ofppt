-- A
create database EFM_2017;
use EFM_2017;
create table M�decin (
	matricule int primary key,
	nomM varchar(50),
	prenomM varchar(50),
	t�l varchar(50),
	sp�cialit� varchar(50)
);
create table Patient (
	numSS int primary key,
	nomP varchar(50),
	prenom varchar(50),
	villeC varchar(50)
);
create table Consultation (
	numConsult int primary key,
	date_consultation date,
	matricule int foreign key references M�decin (matricule)
	on delete set null on update cascade,
	numSS int foreign key references Patient (numSS)
	on delete set null on update cascade,
	descriptionn varchar(50)
);

-- B
create proc DerniDateConsultation
	@numSS int, @date_derniere_consultation date output
as
begin
	set @date_derniere_consultation = (select max(date_consultation) from Consultation where numSS = @numSS);
end

select * from M�decin where sp�cialit� = '1'