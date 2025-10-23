USE SalonMody;

DROP TABLE IF EXISTS kreacja;
DROP TABLE IF EXISTS Element;
DROP TABLE IF EXISTS Stroj;

CREATE TABLE Stroj (
    idStroj INT PRIMARY KEY AUTO_INCREMENT,
    nazwaStroj VARCHAR(255),
    dataUtworzenia DATE,
    dataWaznosci DATE,
    firma VARCHAR(255),
    wlasciciel VARCHAR(255)
);

CREATE TABLE Element (
    idElement INT PRIMARY KEY AUTO_INCREMENT,
    nazwaElementu VARCHAR(255),
    kategoria VARCHAR(100),
    kolor VARCHAR(100),
    rozmiar VARCHAR(5)
);

CREATE TABLE kreacja (
    idKreacja INT PRIMARY KEY AUTO_INCREMENT,
    idStroj INT,
    idElement INT,
    FOREIGN KEY (idStroj) REFERENCES Stroj(idStroj),
    FOREIGN KEY (idElement) REFERENCES Element(idElement),
    dataUtworzenia DATE
);

INSERT INTO Stroj VALUES (NULL, "Wieczorowy","2023-11-20", "2023-12-20", "T19", "Bartosz");
INSERT INTO Stroj VALUES (NULL, "Skejtowy","2023-11-21", "2023-12-21", "Skejtpark", "Wojtek");