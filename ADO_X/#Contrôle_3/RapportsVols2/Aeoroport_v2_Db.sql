use Aeoroport_v2_Db;
select * from Passager where Ville = 'Nice';

select  sum(Prix), Vol.*, Pilote.Nom, Avion.Marque, Avion.TypeAvion, Avion.Capacite, AffecteVol.Prix
from Vol 
inner join AffecteVol on Vol.vol# = AffecteVol.vol
inner join Avion on Vol.Avion = Avion.Av# 
inner join Pilote on Vol.pilote = Pilote.pil#
where vol# = 100
group by vol#

create proc sp_vol
	@vol# int
as

select vol#, villedepart, villearrivee, heuredepart, heurearrivee, 
Pilote.Nom, Avion.Marque, Avion.TypeAvion, Avion.Capacite, sum(AffecteVol.Prix) as RevenuTotal
from Vol 
inner join AffecteVol on Vol.vol# = AffecteVol.vol
inner join Avion on Vol.Avion = Avion.Av# 
inner join Pilote on Vol.pilote = Pilote.pil#
where vol# = 100
group by vol#, villedepart, villearrivee, heuredepart, heurearrivee, 
Nom, Marque, TypeAvion, Capacite



exec sp_vol 1;

select sum(Prix) from V_Vol where vol# = 100;

select sum(Prix) from AffecteVol where vol = 100

select year(getdate())-5 
select * from AffecteVol where year(datevol) between year(getdate())-5 and year(getdate());

select * from AffecteVol where datevol between year(getdate())-5 and year(getdate()); 

select * from Vol;
select * from Pilote where pil# = 1;
select * from AffecteVol

alter proc sp_villes
as
	select distinct villedepart as 'Ville' from Vol
	union
	select distinct villearrivee as 'Ville' from Vol;

create proc sp_nbr_vols_départ
	@ville varchar(max)
as
	select count(*) as 'Nombre de vols au départ' from vol where villedepart = @ville

exec sp_nbr_vols_départ 'nice';