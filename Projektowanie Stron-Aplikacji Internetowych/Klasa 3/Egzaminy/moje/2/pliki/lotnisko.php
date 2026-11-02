<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Port Lotniczy</title>
    <link rel="stylesheet" href="styl5.css">
</head>
<body>
    <div class="banery">
        <section id="baner1">
        <img src="zad5.png" alt="logo lotnisko">
        </section>
        <section id="baner2">
            <h1>Przyloty</h1>
        </section>
        <section id="baner3">
            <h3>przydatne linki</h3>
            <a href="kwerendy.txt" target="_blank">Pobierz...</a>
        </section>
    </div>
    

    <section id="glowny">
        <table>
            <th>czas</th>
            <th>kierunek</th>
            <th>numer rejsu</th>
            <th>status</th>
            
            <?php
                $conn = new mysqli("localhost","root","","egzamin"); $query = "SELECT czas, kierunek, nr_rejsu, status_lotu from przyloty ORDER BY czas;"; $result = $conn -> query($query); while ($row = $result -> fetch_array()) {echo "<tr> <td>$row[0]</td> <td>$row[1]</td> <td>$row[2]</td> <td>$row[3]</td></tr>";}; $conn -> close();
            ?>
        </table>
    </section>

    <section id="stopka1">
        <?php
        if (isset($_COOKIE["visited"])) {
            echo "<p><i>Witaj ponownie na stronie lotniska</i></p>";
        } else {
            setcookie("visited", 7200);
            echo "<p><b>Dzień dobry! Strona lotniska używa ciasteczek</b></p>";
        }
        
        ?>
    </section>
    <section id="stopka2">
        Autor: 200
    </section>
</body>
</html>