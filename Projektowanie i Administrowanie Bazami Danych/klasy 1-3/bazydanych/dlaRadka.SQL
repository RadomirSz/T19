SELECT CONCAT(klienci.ImieKlienta," ",klienci.NazwiskoKlienta) as "NAZWA", "KLIENT" AS TYP
FROM klienci 
INNER JOIN zamowienia ON klienci.IDKlienta = zamowienia.IDKlienta
INNER JOIN dane_zamowien ON zamowienia.NumerZamowienia = dane_zamowien.NumerZamowienia
INNER JOIN produkty ON dane_zamowien.NumerProduktu = produkty.NumerProduktu
AND produkty.NazwaProduktu LIKE "Kask%"

UNION

SELECT dostawcy.NazwaDostawcy, "DOSTAWCA" AS TYP
FROM dostawcy
INNER JOIN dostawcy_produktow ON dostawcy.IDDostawcy = dostawcy_produktow.IDDostawcy
INNER JOIN produkty ON dostawcy_produktow.NumerProduktu = produkty.NumerProduktu
AND produkty.NazwaProduktu LIKE "Kask%"