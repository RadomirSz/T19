-- 12.1
SELECT * FROM klienci ORDER BY nazwisko;

-- 12_2
SELECT DISTINCT marka, model 
FROM samochody 
WHERE rocznik >= 2010 
AND rocznik <= 2020 
AND moc > 100 
ORDER BY marka, model;

-- 12_3
SELECT klienci.Id, klienci.imie, klienci.nazwisko, Count(samochody.id) AS PoliczOfid
FROM klienci LEFT JOIN samochody ON klienci.Id = samochody.wlasciciel
GROUP BY klienci.Id, klienci.imie, klienci.nazwisko
ORDER BY Count(samochody.id) DESC;
