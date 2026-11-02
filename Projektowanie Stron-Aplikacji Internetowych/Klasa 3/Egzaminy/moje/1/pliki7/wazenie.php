<?php
header("Refresh: 10;");
?>

<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ważenie samochodów ciężarowych</title>
    <link rel="stylesheet" href="styl.css">
</head>
<body>
    <div class="naglowek">
        <header id="header1">
            <h1>Ważenie pojazdów we Wrocławiu</h1>
        </header>
        <header id="header2">
            <img src="obraz1.png" alt="waga">
        </header>
    </div>
    
<main>
    <section id="lewy">
        <h2>Lokalizacje wag</h2>
        <ol>
            <?php
            $conn = mysqli_connect("localhost", "root","","wazenietirow");
            $query = "SELECT lokalizacje.ulica FROM lokalizacje";
            $result = mysqli_query($conn, $query);

            while ($row = mysqli_fetch_row($result)) {
                echo "<li>ulica $row[0]</li>";
            }
            ?>
        </ol>
        <h2>Kontakt</h2>
        <a href="mailto:wazenie@wroclaw.pl">napisz</a>
    </section>
    <section id="srodkowy">
        <h2>Alerty</h2>

        <table>
            <tr>
                <td>rejestracja</td>
                <td>ulica</td>
                <td>waga</td>
                <td>dzień</td>
                <td>czas</td>
            </tr>
            <?php
                $query = "SELECT wagi.rejestracja, lokalizacje.ulica, wagi.waga, wagi.dzien, wagi.czas FROM wagi JOIN lokalizacje ON wagi.lokalizacje_id = lokalizacje.id WHERE wagi.waga > 5;";
                $result = mysqli_query($conn, $query);
                while ($row = mysqli_fetch_row($result)) {
                    echo "<tr>
                    <td>$row[0]</td>
                    <td>$row[1]</td>
                    <td>$row[2]</td>
                    <td>$row[3]</td>
                    <td>$row[4]</td>
                        </tr>";
                }
            ?>
        </table>
        <?php
            $query = "INSERT INTO wagi(wagi.lokalizacje_id, wagi.waga, wagi.rejestracja, wagi.dzien, wagi.czas) VALUES (5,FLOOR(1+RAND()*10),'DW12345', CURRENT_DATE, CURRENT_TIME);";
            mysqli_query($conn, $query);
            mysqli_close($conn);
        ?>
    </section>
    <section id="prawy">
        <img src="obraz2.jpg" alt="tir">
    </section>
<main>
    <footer>
        <p>Stronę wykonał: XYZ</p>
    </footer>
</body>
</html>