<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Zadania na lipiec</title>
    <link rel="stylesheet" href="styl6.css">
</head>
<body>
    <section id="baner">
        <header id="baner1">
            <img src="logo1.png" alt="lipiec">
        </header>
        <header id="baner2">
            <h1>TERMINARZ</h1>
            <p>najbliższe zadania: 
                <?php
                $conn = new mysqli("localhost","root","","terminarz");
                $query = "SELECT DISTINCT wpis FROM zadania WHERE dataZadania <= '2020-07-07' AND wpis != '';";
                $result = $conn -> query($query);
                $output = "";
                while ($row = $result -> fetch_array()) {
                    $output .= " ".$row[0].";";
                }
                echo $output;
                ?>
            </p>
        </header>
    </section>
    <main>
        <?php
            $query = "SELECT dataZadania, wpis FROM zadania WHERE miesiac = 'lipiec';";
            $result = $conn -> query($query);

            while ($row = $result -> fetch_array()) {
                echo "
                    <section id='blokKalendarza'>
                        <h6>$row[0]</h6>
                        <p>$row[1]</p>
                    </section>
                ";
            }
            $conn -> close();
        ?>
    </main>
    <footer>
        <a href="sierpien.html">Terminarz na sierpień</a>
        <p>Stronę wykonał: 200</p>
    </footer>  
</body>
</html>