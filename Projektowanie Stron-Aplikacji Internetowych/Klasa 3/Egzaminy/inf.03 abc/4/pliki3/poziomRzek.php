<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Poziomy rzek</title>
    <link rel="stylesheet" href="styl.css">
</head>
<body>
    <div class="baner">
        <header>
            <img src="obraz1.png" alt="Mapa Polski">
        </header>
        <header>
            <h1>Rzeki w województwie dolnośląskim</h1>
        </header>
    </div>
    <menu>
        <form action="poziomRzek.php" method="post">
            <input type="radio" name="opcje" id="opcja1" value="wszystkie">
            <label for="opcja1">Wszystkie</label>
            <input type="radio" name="opcje" id="opcja2" value="ostrzegawczy">
            <label for="opcja2">Ponad stan ostrzegawczy</label>
            <input type="radio" name="opcje" id="opcja3" value="alarmowy">
            <label for="opcja3">Ponad stan alarmowy</label>
            <button type="submit">Pokaż</button>
        </form>
    </menu>
    <main>
        <section id="lewy">
        <h3>Stany na dzień 2022-05-05</h3>
        <table>
            <tr>
                <td>Wodomierz</td>
                <td>Rzeka</td>
                <td>Ostrzegawczy</td>
                <td>Alarmowy</td>
                <td>Aktualny</td>
            </tr>
            <?php
                $conn = mysqli_connect( "localhost","root", "","rzeki");
                
                if (isset($_POST['opcje'])) {
                    $opcja = $_POST['opcje'];
                    if ($opcja == 'wszystkie') {
                        $query = "SELECT nazwa, rzeka, stanOstrzegawczy, stanAlarmowy, stanWody 
                        FROM wodowskazy JOIN pomiary ON wodowskazy.id = pomiary.wodowskazy_id 
                        WHERE pomiary.dataPomiaru = '2022-05-05';";
                    } else if($opcja == 'ostrzegawczy') {
                        $query = "SELECT nazwa, rzeka, stanOstrzegawczy, stanAlarmowy, stanWody 
                        FROM wodowskazy JOIN pomiary ON wodowskazy.id = pomiary.wodowskazy_id 
                        WHERE pomiary.dataPomiaru = '2022-05-05' AND pomiary.stanWody > wodowskazy.stanOstrzegawczy;";
                    } else if($opcja == 'alarmowy') {
                        $query = "SELECT nazwa, rzeka, stanOstrzegawczy, stanAlarmowy, stanWody 
                        FROM wodowskazy JOIN pomiary ON wodowskazy.id = pomiary.wodowskazy_id 
                        WHERE pomiary.dataPomiaru = '2022-05-05' AND pomiary.stanWody > wodowskazy.stanAlarmowy;";
                    }
                    
                    $result = mysqli_query($conn, $query);
                    while ($row = mysqli_fetch_row($result)) {
                        echo "
                        <tr>
                            <td>$row[0]</td>
                            <td>$row[1]</td>
                            <td>$row[2]</td>
                            <td>$row[3]</td>
                            <td>$row[4]</td>
                        </tr>
                        ";
                    }
                }
            ?>
        </table>
    </section>
    <section id="prawy">
        <h3>Informacje</h3>
        <ul>
            <li>Brak ostrzeżeń o burzach z gradem</li>
            <li>Smog w mieście Wrocław</li>
            <li>Silny wiatr w Karkonoszach</li>
        </ul>
        <h3>Średnie stany wód</h3>
        <?php
            $query = "SELECT pomiary.dataPomiaru, AVG(pomiary.stanWody) FROM pomiary GROUP BY pomiary.dataPomiaru;";
            $result = mysqli_query($conn, $query);
            while ($row = mysqli_fetch_row($result)) {
                echo "<p>$row[0]: $row[1]</p>";
            }
            mysqli_close($conn);
        ?>
        <a href="https://komunikaty.pl">Dowiedz się więcej</a>
        <img src="obraz2.jpg" alt="rzeka">
    </section>
    </main>
    <footer>
        <p>Stronę wykonał: 200</p>
    </footer>
</body>
</html>