/*CREATE DATABASE ksiegarnia;*/
     
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
			CONSTRAINT kluczKsiazki PRIMARY KEY (IDksiazka)
		);
		
CREATE TABLE zamowienia
		(
			IDksiazka integer NOT NULL ,
			klientImie character(30),
			klientNazwisko character(30)
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

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('1', 'Pan Tadeusz','1','12');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('2', 'Grażyna','1','22');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('3', 'Ballady i romanse','1','15');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('4', 'Pan Tadeusz','1','33');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('5', 'Pan Tadeusz','1','55');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('6', 'Treny','2','78');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('7', 'Fraszki','2','65');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('8', 'Treny','2','35');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('9', 'Treny','2','69');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('10', 'Fraszki','2','44');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('11', 'Emancypantki','3','69');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('12', 'Emancypantki','3','99');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('13', 'Emancypantki','3','25');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('14', 'Emancypantki','3','75');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('15', 'Emancypantki','3','33');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('16', 'Ogniem i mieczem','5','69');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('17', 'Potop','5','159');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('18', 'Pan Wołodiowski','5','222');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('19', 'Krzyżacy','5','147');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena)
VALUES ('20', 'Quo vadis','5','25');


/*tabela zamowienia*/

INSERT INTO zamowienia (IDksiazka,klientImie,klientNazwisko)
VALUES ('1', 'Adam','Kowalski');
INSERT INTO zamowienia (IDksiazka,klientImie,klientNazwisko)
VALUES ('2', 'Jan','Kowalski');
INSERT INTO zamowienia (IDksiazka,klientImie,klientNazwisko)
VALUES ('20', 'Jan','Nowak');