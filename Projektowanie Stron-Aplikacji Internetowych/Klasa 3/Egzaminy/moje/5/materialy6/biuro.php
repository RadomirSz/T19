<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Poznaj Europę</title>
    <link rel="stylesheet" href="styl9.css">
</head>
<body>
    <header>
        <h1>BIURO PODRÓŻY</h1>
    </header>
    <main>
        <section id="lewy">
            <h2>Promocje</h2>
            <table>
                <tr>
                    <td>Warszawa</td><td>od 600 zł</td>
                </tr>
                <tr>
                    <td>Wenecja</td><td>od 1200 zł</td>
                </tr>
                <tr>
                    <td>Paryż</td><td>od 1200 zł</td>
                </tr>
            </table>
        </section>
        <section id="srodkowy">
            <h2>W tym roku jedziemy do...</h2>
            <?php
            $conn = mysqli_connect("localhost","root","","podroze");
            $query = "SELECT nazwaPliku, podpis FROM zdjecia ORDER BY podpis;";
            $result = mysqli_query($conn,$query);

            while ($row = mysqli_fetch_array($result)) {
                echo "<img src='$row[0]' alt='$row[1]' title='$row[1]'>";
            }
            ?>
        </section>
        <section id="prawy">
            <h2>Kontakt</h2>
            <a href="mailto:biuro@wycieczki.pl">napisz do nas</a>
            <p>telefon: 444555666</p>
        </section>
    </main>
    <section id="dane">
        <h3>W poprzednich latach byliśmy...</h3>
        <ol>
            <?php
                $query = "SELECT cel, dataWyjazdu FROM wycieczki WHERE dostepna = 0;";
                $result = mysqli_query($conn,$query);
        
                while ($row = mysqli_fetch_array($result)) {
                    echo "<li>Dnia $row[1] pojechaliśmy do $row[0]</li>";
                }
                mysqli_close($conn);
            ?>
        </ol>
    </section>
    <footer>
        <p>Stronę wykonał: 200</p>
    </footer>
</body>
</html>