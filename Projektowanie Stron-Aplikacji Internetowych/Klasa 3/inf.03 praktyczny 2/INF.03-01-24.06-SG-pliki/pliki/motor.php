<!DOCTYPE html>
<html lang="pl">

<head>
    <meta charset="UTF-8">
    <title>Motocykle</title>
    <link rel="stylesheet" href="styl.css">
</head>

<body>
    <img id="motorpng" src="motor.png" alt="motocykl">
    <header>
        <h1>Motocykle - moja pasja</h1>
    </header>
    <main>
        <section id="left">
            <h2>Gdzie pojechać?</h2>
            <dl>
                <?php
                $conn = new mysqli("localhost", "root", "", "motory");
                $query = "SELECT wycieczki.nazwa, wycieczki.opis, wycieczki.poczatek, zdjecia.zrodlo from wycieczki inner join zdjecia on wycieczki.zdjecia_id = zdjecia.id;";

                $result = $conn->query($query);

                while($row = $result->fetch_array()) {
                    echo "<dt>$row[0] rozpoczyna się w $row[2], <a href='./$row[3].jpg'>Zobacz zdjęcie</a></dt>";
                    echo "<dd>$row[1]</dd>";
                }
                ?>
            </dl>
        </section>
        <section id="right">
            <section id="topright">
                <h2>Co kupić?</h2>
                <ol>
                    <li>Honda CBR125R</li>
                    <li>Yamaha YBR125</li>
                    <li>Honda VFR800i</li>
                    <li>Honda CBR1100XX</li>
                    <li>BMW R1200GS LC</li>
                </ol>
            </section>
            <section id="bottomright">
                <h2>Statystyki</h2>
                <p>Wpisanych wycieczek: 
                    <?php
                    $query = "SELECT COUNT(wycieczki.id) FROM wycieczki;";
                    $result = $conn->query($query);
                    $row = $result->fetch_array();
                    echo "$row[0]";
                    mysqli_close($conn);
                    ?>
                </p>
                <p>Użytkowników forum: 200</p>
                <p>Przesłanych zdjęć: 1300</p>
            </section>
        </section>
    </main>
    <footer>
        <p>Stronę wykonał: 1738</p>
    </footer>
</body>
</html>
