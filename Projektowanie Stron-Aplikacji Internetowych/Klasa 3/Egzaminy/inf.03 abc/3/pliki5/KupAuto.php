<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Komis aut</title>
    <link rel="stylesheet" href="styl.css">
</head>
<body>

    <header>
        <h1><i>KupAuto!</i> Internetowy Komis Samochodowy</h1>
    </header>
    <main>
        <section id="glowny1">
            <?php
            $conn = new mysqli("localhost","root","","kupauto");
            $query = "SELECT model, rocznik, przebieg, paliwo, cena, zdjecie FROM samochody WHERE id = 10;";
            $result = $conn -> query($query);
            while ($row = $result -> fetch_array()) {
                echo "
                    <img src='$row[5]' alt='oferta dnia'>
                    <h4>Oferta Dnia: Toyota $row[0]</h4>
                    <p>Rocznik: $row[1], przebieg: $row[2], rodzaj paliwa: $row[3]</p>
                    <h4>Cena: $row[4]</h4>
                ";
            }
            ?>
        </section>
        <section id="glowny2">
            <h2>Oferty Wyróżnione</h2>
            <?php
                $query = "SELECT nazwa, model, rocznik, cena, zdjecie FROM marki JOIN samochody ON marki.id = samochody.marki_id WHERE wyrozniony = 1 LIMIT 4;";
                $result = $conn -> query($query);
                while ($row = $result -> fetch_array()) {
                    echo "
                        <div>
                            <img src='$row[4]' alt='$row[1]'>
                            <h4>$row[0] $row[1]</h4>
                            <p>Rocznik: $row[2]</p>
                            <h4>Cena: $row[3]</h4>
                        </div>
                    ";
                }
            //43 min jakoś, przerwa + 16:40 
            ?>
        </section>
        <section id="glowny3">
            <h2>Wybierz markę</h2>
            <form action="KupAuto.php" method="post">
                <select name="lista" id="lista">
                    <?php
                        $query = "SELECT nazwa FROM marki;";
                        $result = $conn -> query($query);
                        while ($row = $result -> fetch_array()) {
                            echo "<option value='$row[0]'>$row[0]</option>";
                        }
                    ?>
                </select>
                <button type="submit">Wyszukaj</button>
            </form>
            <?php
                if(isset($_POST['lista'])){
                    $marka = $_POST['lista'];
                    $query = "SELECT model, cena, zdjecie FROM samochody JOIN marki ON samochody.marki_id = marki.id WHERE nazwa = '$marka';";

                    $result = $conn -> query($query);
                    while ($row = $result -> fetch_array()) {
                        echo "
                            <div>
                                <img src='$row[2]' alt='$row[0]'>
                                <h4>$marka $row[0]</h4>
                                <h4>Cena: $row[1]</h4>
                            </div>
                            ";
                    }
                }
                
                $conn -> close();
            ?>
        </section>
    </main>
    <footer>
        <p>Stronę wykonał: 200</p>
        <a href="http://firmy.pl/komis">Znajdź nas także</a>
    </footer>

</body>
</html>