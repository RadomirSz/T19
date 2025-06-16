<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Szkolenia i kursy</title>
    <link rel="stylesheet" href="styl.css">
</head>
<body>
    <header>
        <h1>SZKOLENIA</h1>
    </header>
    <main>
        <section class="lewa">
            <table>
                <thead>
                    <tr>
                        <th>Kurs</th>
                        <th>Nazwa</th>
                        <th>Cena</th>
                    </tr>
                </thead>
                <tbody>
                    <!-- Skrypt 1 wypełni tabelę -->
                    <?php
                    // Skrypt 1: Wypełnienie tabeli danymi
                    
                    ?>
                </tbody>
            </table>
        </section>
        <section class="prawa">
            <h2>Zapisy na kursy</h2>
            <form action="index.php" method="post">
                <label for="imie">Imię</label>
                <input type="text" id="imie" name="imie" required>

                <label for="nazwisko">Nazwisko</label>
                <input type="text" id="nazwisko" name="nazwisko" required>

                <label for="wiek">Wiek</label>
                <input type="number" id="wiek" name="wiek" required>

                <label for="rodzaj">Rodzaj kursu</label>
                <select id="rodzaj" name="rodzaj">
                    <!-- Skrypt 2 wypełni listę rozwijaną -->
                    
                </select>

                <button type="submit" name="dodaj">Dodaj dane</button>
            </form>
            <?php
            if (isset($_POST['dodaj'])) {
                        $imie = $_POST['imie'];
                        $nazwisko = $_POST['nazwisko'];
                        $wiek = $_POST['wiek'];
                        $rodzaj = $_POST['rodzaj'];

                        if (!empty($imie) && !empty($nazwisko) && !empty($wiek) && !empty($rodzaj)) {
                            $stmt = $conn->"INSERT INTO uczestnicy (imie, nazwisko, wiek, rodzaj) VALUES (?, ?, ?, ?)");
                            echo "<p>Dane uczestnika $imie $nazwisko zostały dodane</p>";
                        } else {
                            echo "<p>Wprowadź wszystkie dane</p>";
                        }
                    }
            ?>
        </section>
    </main>
    <footer>
        <p>Stronę wykonał: 123456</p>
    </footer>
</body>
</html>