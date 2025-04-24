<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Hodowla świnek morskich</title>
    <link rel="stylesheet" href="styl.css">
</head>
<body>
    <header> 
        <h1>Hodowla  świnek  morskich  -  zamów świnkowe maluszki</h1>    
    </header>
    <main>
        <section id="prawy">
            <h3>Poznaj wszystkie rasy świnek morskich</h3>
            <ol>
                <?php
                $conn = new mysqli("localhost", "root", "", "hodowla");
                $query = "SELECT rasy.rasa FROM rasy";
                $result = $conn->query($query); 
        
                while ($row = $result->fetch_array()) {
                    echo "<li>$row[0]</li>";
                }
                ?>
            </ol>
        </section>
        <section id="menu">
            <a href="peruwianka.php">Rasa Peruwianka</a>
            <a href="american.php">Rasa American</a>
            <a href="crested.php">Rasa Crested</a>
        </section>
        <section id="główny">
            <img src="american.jpg" alt="Świnka morska rasy american">
            <?php
            $query = "SELECT DISTINCT swinki.data_ur, swinki.miot, rasy.rasa FROM swinki INNER JOIN rasy ON swinki.rasy_id = rasy.id WHERE swinki.rasy_id = 6;";
            $result = $conn->query($query);
            $data = $result->fetch_array();

            echo "<h2>Rasa: $data[2]</h2>";
            echo "<p>Data urodzenia: $data[0]</p>";
            echo "<p>Oznaczenie miotu: $data[1]</p>";
            ?>
            <hr>
            <h2>Świnki w tym miocie</h2>
            <?php
            $query = "SELECT swinki.imie, swinki.cena, swinki.opis FROM swinki WHERE swinki.rasy_id = 6;";

            $result = $conn->query($query);
            while($row = $result->fetch_array()) {
                echo "<h3>$row[0] - $row[1]</h3>";
                echo "<p>$row[2]</p>";
            }
            $conn->close();
            ?>
        </section>
    </main>
    <footer>
    <p>Stronę wykonał: XYZ</p>
    </footer>
</body>
</html>