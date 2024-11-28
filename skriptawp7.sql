-- ovako se pisu komentari

use master;
go
drop database if exists test123;
go
create database test123;
go 
use test123;
go


create table ispitnirok(
sifra int, 
predmet varchar (20),
vrstaispita varchar (20),
datum int, 
pristupio varchar (20)
);

create table pristupnici(
ispitnirok varchar(20),
student varchar(20),
brojbodova int,
ocjena varchar(20),
);
