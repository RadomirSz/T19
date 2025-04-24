-- 12.1
SELECT * FROM klienci ORDER BY nazwisko;

-- 12.2

SELECT DISTINCT marka, model 
FROM samochody 
WHERE rocznik >= 2010 
AND rocznik <= 2020 
AND moc > 100 
ORDER BY marka, model;


