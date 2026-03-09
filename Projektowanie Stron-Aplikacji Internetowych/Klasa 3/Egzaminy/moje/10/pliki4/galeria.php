<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Galeria</title>
    <link rel="stylesheet" href="styl.css">
</head>
<body>
    <header>
        <h1>Zdjęcia</h1>
    </header>
    <main>
        <section id="lewy">
            <h2>Tematy zdjęć</h2>
            <ol>
                <li>Zwierzęta</li>
                <li>Krajobrazy</li>
                <li>Miasta</li>
                <li>Przyroda</li>
                <li>Samochody</li>
            </ol>
        </section>
        <section id="srodkowy">
            <?php
                $conn = new mysqli('localhost','root','','galeria');
                $query2 = "SELECT plik, tytul, polubienia, imie, nazwisko FROM zdjecia join autorzy ON zdjecia.autorzy_id = autorzy.id ORDER BY nazwisko;";
                $result = $conn ->query($query2);
                $out = '';
                while ($row = $result ->fetch_array()) {
                    $out ="
                    <div>
                        <img src='$row[0]' alt='zdjęcie'>
                        <h3>$row[1]</h3>
                    ";
                    if($row[2] > 40){
                        $out .= "<p>Autor: $row[3] $row[4].<br> Wiele osób polubiło ten obraz</p>";
                    }
                    else {
                        $out .= "<p>Autor: $row[3] $row[4].</p>";
                    }
                    $out .= "<a href='$row[0]' download>Pobierz</a></div>";
                    echo $out;
                }
            ?>
        </section>
        <section id="prawy">
            <h2>Najbardziej lubiane</h2>
            <?php
                $query1 = "SELECT tytul, plik FROM zdjecia WHERE polubienia >=100;";
                $result = $conn -> query($query1);
                while ($row = $result->fetch_array()) {
                    echo "<img src='$row[1]' alt='$row[0]'>";
                }
                $conn -> close();
            ?>
            <strong>Zobacz wszystkie nasze zdjęcia</strong>
        </section>
    </main>
    <footer>
        <h5>Stronę wykonał: 200</h5>
    </footer>
</body>
</html>