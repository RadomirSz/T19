
/*CREATE DATABASE ksiegarnialasa;*/
     
CREATE TABLE autorzy
		(
			IDautor serial NOT NULL ,
			nazwisko character(30),
			imie character(30),
			CONSTRAINT kluczAutorzy PRIMARY KEY (IDautor)
		);

CREATE TABLE ksiazki
		(
			IDksiazka serial NOT NULL ,
			tytul character(30),
			autor integer,
			cena integer,
			dataZakupu date,
			ilosc integer,
			notatka longtext,
			CONSTRAINT kluczKsiazki PRIMARY KEY (IDksiazka)
		);
		
CREATE TABLE klienci
		(
			IDklient character(36) NOT NULL,
			klImie character(30),
			klNazwisko character(30),
			ulica character(30),
			nrLokalu character(10),
			kod character(10),
			miejscowosc character(60),
			telefon character(20),
			poczta character(50),
			CONSTRAINT kluczKlienci PRIMARY KEY (IDklient)
		);		

CREATE TABLE zamowienia
		(
			IDklient character(36) NOT NULL ,
			IDksiazka integer NOT NULL,
			zamIlosc integer NOT NULL,
			cena integer NOT NULL,
			wartosc integer NOT NULL,
			platnosc character(25)
		);

/*tabela autorzy*/

INSERT INTO autorzy (IDautor,imie,nazwisko)
VALUES ('1', 'Adam','Mickiewicz');

INSERT INTO autorzy (IDautor,imie,nazwisko)
VALUES ('2', 'Jan','Kochanowski');

INSERT INTO autorzy (IDautor,imie,nazwisko)
VALUES ('3', 'Bolesław','Prus');

INSERT INTO autorzy (IDautor,imie,nazwisko)
VALUES ('4', 'Juliusz','Słowacki');

INSERT INTO autorzy (IDautor,imie,nazwisko)
VALUES ('5', 'Henryk','Sienkiewicz');


/*tabela ksiazki*/

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('1', 'Pan Tadeusz','1','12','1999-12-01','100','Pan Tadeusz egzemplarz 1');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('2', 'Grażyna','1','22','2019-12-01','100','Grażyna egzemplarz 1');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('3', 'Ballady i romanse','1','15','1987-11-15','100','Ballady i romanse egzemplarz 1');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('4', 'Pan Tadeusz','1','33','2009-01-22','100','Pan Tadeusz egzemplarz 2');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('5', 'Pan Tadeusz','1','55','2009-12-01','100','Pan Tadeusz egzemplarz 3');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('6', 'Treny','2','78','1999-12-01','100','Treny egzemplarz 1');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('7', 'Fraszki','2','65','1959-10-11','100','Fraszki egzemplarz 1');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('8', 'Treny','2','35','2019-03-01','100','Treny egzemplarz 2');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('9', 'Treny','2','69','2006-01-22','100','Treny egzemplarz 3');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('10', 'Fraszki','2','44','1966-12-01','100','Fraszki egzemplarz 2');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('11', 'Emancypantki','3','69','2001-12-01','100','Emancypantki egzemplarz 1');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('12', 'Emancypantki','3','99','2011-05-09','100','Emancypantki egzemplarz 2');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('13', 'Emancypantki','3','25','2025-08-21','100','Emancypantki egzemplarz 3');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('14', 'Emancypantki','3','75','2011-11-11','100','Emancypantki egzemplarz 4');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('15', 'Emancypantki','3','33','2031-06-16','100','Emancypantki egzemplarz 5');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('16', 'Ogniem i mieczem','5','69','2001-12-01','100','Ogniem i mieczem egzemplarz 1');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('17', 'Potop','5','159','2011-12-01','100','Potop egzemplarz 1');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('18', 'Pan Wołodjowski','5','222','2021-02-16','100','Pan Wołodjowski egzemplarz 1');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('19', 'Krzyżacy','5','147','2051-09-01','100','Krzyżacy egzemplarz 1');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu,ilosc,notatka)
VALUES ('20', 'Quo vadis','5','25','2001-12-01','100','Quo vadis egzemplarz 1');


/*tabela klienci*/

INSERT INTO klienci (IDklient,klImie,klNazwisko,ulica,nrLokalu,kod,miejscowosc,telefon,poczta)
VALUES ('1', 'Adam','Kowalski','Towarowa','1a/3','33-535','Kozubki Szczęśliwe','555 777 111','aKowal@gmail.com');
INSERT INTO klienci (IDklient,klImie,klNazwisko,ulica,nrLokalu,kod,miejscowosc,telefon,poczta)
VALUES ('2', 'Barbara','Kowalska','Pocztowa','178','93-305','Kozubki Dobrotliwe','555 098 383','bKowalowa@gmail.com');
INSERT INTO klienci (IDklient,klImie,klNazwisko,ulica,nrLokalu,kod,miejscowosc,telefon,poczta)
VALUES ('3', 'Jan','Nowak','Dekarska','91h/37','39-035','Kowalewo','190-915-367','jNowak@gmail.com');
INSERT INTO klienci (IDklient,klImie,klNazwisko,ulica,nrLokalu,kod,miejscowosc,telefon,poczta)
VALUES ('4', 'Barnaba','Nowak','Piekarska','51k/788','71-235','Szczytniki','586-924-379','bNowak@gmail.com');

/*tabela zamowienia*/

INSERT INTO zamowienia (IDklient,IDksiazka,zamIlosc,cena,wartosc,platnosc)
VALUES ('1', '3','4','15','60','Stripe');
INSERT INTO zamowienia (IDklient,IDksiazka,zamIlosc,cena,wartosc,platnosc)
VALUES ('2', '15','1','33','33','przelew on line');
INSERT INTO zamowienia (IDklient,IDksiazka,zamIlosc,cena,wartosc,platnosc)
VALUES ('2', '10','7','44','328','PayPal');
INSERT INTO zamowienia (IDklient,IDksiazka,zamIlosc,cena,wartosc,platnosc)
VALUES ('3', '19','5','147','735','Karta kredytowa');