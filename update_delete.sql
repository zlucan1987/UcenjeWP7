
-- Update naredba mijenja podatke u tablici

select * from smjerovi where sifra=2;

-- mjenjanje samo jedne kolone
update smjerovi
set trajanje=300
where sifra=2;

--mjenjanje više kolona
update smjerovi
set trajanje=200, cijena=1000,vaucer=0
where sifra=3;

update smjerovi set cijena = 999 where sifra=2;
update smjerovi set cijena = 777.55 where sifra=4;
select * from smjerovi;
update smjerovi set cijena = cijena * 1.1;
select * from smjerovi;

-- svim smjerovima smanjite cijenu za 10 €
select * from smjerovi;
update smjerovi set cijena = cijena - 10;
select * from smjerovi;

-- Smjeru Serviser promjenite početak izvođenja na 
-- 02. listopad 2024 u 18:30

update smjerovi 
set izvodiseod='2024-10-02 18:30'
where sifra=3;

-- Delete naredba briše podatke iz tablice
-- briše se cijeli red

delete grupe where smjer=1;
delete from clanovi where grupa=2;
delete smjerovi where sifra=1;

-- Dodati sebi omiljenu osobu kao polaznika

-- Promjeniti OIB omiljenoj osobi na 64733268826

-- obrišite omiljenu osobu kao polaznika






select * from grupe;
