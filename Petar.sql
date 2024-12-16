use master;
go
drop database  if exists lol ;
go
create database lol collate Croatian_CI_AS;
go 
use lol;

create table moci(
sifra int not null primary key identity (1,1),
ime varchar(20) not null,
vrsta varchar(50) not null
);
create table rune(
sifra int not null primary key identity (1,1),
ime varchar(20) not null ,  
moc int not null references moci(sifra)
);

create table heroji(
sifra int not null primary key identity(1,1),
ime varchar(20) not null ,
runa int not null references rune(sifra),
razina int null,
datum_izlaska date  null,
primarna_moc int not null references moci(sifra),
sekundarna_moc int null references moci(sifra) 
);

insert into moci(ime, vrsta) values
('Sokeri','izdaljine'),
('Domination','izblizine');


insert into rune(ime,moc) values
('sorcery',1),
('precision',2),
('resolve',2);

INSERT INTO heroji(ime, runa,primarna_moc ) VALUES
('Aatrox', 2,2),
('Ahri', 1, 1),
('Jhin',1,2),
('Jinx',1,2);



