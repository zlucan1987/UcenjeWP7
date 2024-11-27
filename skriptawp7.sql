-- ovako se pisu komentari

use master;
go
drop database if exists edunovawp7;
go
create database test123;
go 
use test123;
go


create table ispitnirok(
sifra int, 
predmet varchar (20),
vrsta ispita varchar (20),
datum int, 
pristupio varchar (20)
);

create table pristupnici(
ispitni rok varchar(20),
student varchar(20),
brojbodova int,
ocjena varchar(20),
);
