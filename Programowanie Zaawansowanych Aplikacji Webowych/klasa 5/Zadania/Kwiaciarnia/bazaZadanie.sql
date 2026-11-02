
/*CREATE DATABASE kwiaciarnia;*/
     
CREATE TABLE kwiaty
		(
			IDkwiat serial NOT NULL ,
			nazwa character(30),
			cena float,
			ilosc integer,
			notatka longtext,
			CONSTRAINT kluczKwiaty PRIMARY KEY (IDkwiat)
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
			IDkwiat integer NOT NULL,
			zamIlosc integer NOT NULL,
			cena float NOT NULL,
			wartosc float NOT NULL,
			platnosc character(25)
		);


/*tabela kwiaty*/

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('1', 'Róże','1.2','28','Róże kwiaty cięte rodzaj 1');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('2', 'Goździki','2.2','28','Goździki kwiaty cięte rodzaj 1');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('3', 'Fiołki','1.5','28','Fiołki kwiaty cięte rodzaj 1');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('4', 'Róże','3.3','28','Róże kwiaty cięte rodzaj 2');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('5', 'Róże','5.5','28','Róże kwiaty cięte rodzaj 3');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('6', 'Irysy','7.8','28','Irysy kwiaty cięte rodzaj 1');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('7', 'Piwonie','6.5','28','Piwonie kwiaty cięte rodzaj 1');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('8', 'Irysy','3.5','28','Irysy kwiaty cięte rodzaj 2');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('9', 'Irysy','6.9','28','Irysy kwiaty cięte rodzaj 3');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('10', 'Piwonie','4.4','28','Piwonie kwiaty cięte rodzaj 2');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('11', 'Frezje','6.9','28','Frezje kwiaty cięte rodzaj 1');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('12', 'Frezje','9.9','28','Frezje kwiaty cięte rodzaj 2');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('13', 'Frezje','2.5','28','Frezje kwiaty cięte rodzaj 3');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('14', 'Frezje','7.5','28','Frezje kwiaty cięte rodzaj 4');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('15', 'Frezje','3.3','28','Frezje kwiaty cięte rodzaj 5');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('16', 'Margaretki','6.9','28','Margaretki kwiaty cięte rodzaj 1');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('17', 'Bratki','1.59','28','Bratki kwiaty cięte rodzaj 1');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('18', 'Bez','2.22','28','Bez kwiaty cięte rodzaj 1');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('19', 'Rumianek','1.47','28','Rumianek kwiaty cięte rodzaj 1');

INSERT INTO kwiaty (IDkwiat,nazwa,cena,ilosc,notatka)
VALUES ('20', 'Lilie','2.5','28','Lilie kwiaty cięte rodzaj 1');


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

INSERT INTO zamowienia (IDklient,IDkwiat,zamIlosc,cena,wartosc,platnosc)
VALUES ('1', '3','4','1.5','6.0','Stripe');
INSERT INTO zamowienia (IDklient,IDkwiat,zamIlosc,cena,wartosc,platnosc)
VALUES ('2', '15','1','3.3','3.3','przelew on line');
INSERT INTO zamowienia (IDklient,IDkwiat,zamIlosc,cena,wartosc,platnosc)
VALUES ('2', '10','7','4.4','30.8','PayPal');
INSERT INTO zamowienia (IDklient,IDkwiat,zamIlosc,cena,wartosc,platnosc)
VALUES ('3', '19','5','1.47','7.35','Karta kredytowa');