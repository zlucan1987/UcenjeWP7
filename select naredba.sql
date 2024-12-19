select * from smjerovi;
-- minimalna select naredba 
select 1;
-- filtriranje kolona(između select i from)
-- * su sve kolone
-- naziv kolone
-- konstantu
-- izraz
select *, naziv, 1 as iznos, GETDATE() as datum from smjerovi;

select naziv as predmet, GETDATE() as datumpocetka from smjerovi;

select sifra, naziv from smjerovi;
select ime, prezime from polaznici;

-- filtriranje redova
-- ide u where dio 
-- = je operator
-- usporedjivanje : =, !=, <,>,<=,>=
-- logički operatori: and, or & not
-- ostali operatori: like (% za bilo koji znak)
-- between 
-- in (ukljucuje vise stvari)

select * from smjerovi
where not (sifra=1 or sifra=4);


select * from polaznici 
where prezime='Nađ';

select * from polaznici 
where prezime like 'N%';

select * from polaznici 
where prezime like '%an%';

-- s najmanjom greškom ispisite sve polaznice

select * from polaznici
where ime like '%a';

--between (najcesce se koristi na datum)

select * from polaznici where sifra>10 and sifra<15;
select * from polaznici where sifra between 10 and 15;

select * from polaznici where sifra=10 or sifra=15 or sifra=1;
select * from polaznici where sifra in (10,15,1);

-- Postavite da 3 smjera se izvode u različitim mjesecima: sijećanj, travanj, listopad.

select * from smjerovi;

update smjerovi 
set izvodiseod= '2024-03-18 18:30'
where sifra=4;

-- izlistajte sve smjerove koji pocinju u prvoj polovini 2024. godine

select * from smjerovi
where izvodiseod between '2021-01-01' and '2024-06-30';