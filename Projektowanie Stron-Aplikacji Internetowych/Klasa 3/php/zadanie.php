<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<form method="post">
    podaj nazwę bazy danych:
    <input name="nazwa" type="text"><br><br>
    podaj nazwę tabeli:
    <input name="tabelanazwa" type="text"><br><br>
    podaj nazwę pól:
    <input name="pole1" type="text">
    <input name="pole2" type="text"><br><br>
    <input type="submit">
</form>
</body>
</html>


<?php
$nazwa = $_POST["nazwa"];
$tabelanazwa = $_POST["tabelanazwa"];
$pole1 = $_POST["pole1"];
$pole2 = $_POST["pole2"];

$servernazwa = "localhost";
$usernazwa = "root";
$password = "";
$conn = mysqli_connect($servernazwa, $usernazwa, $password);
if (!$conn) {
    die("Połączenie nieudane: " .mysqli_connect_error());
}
$sql = "CREATE DATABASE $nazwa";
if (mysqli_query($conn, $sql)) {
    echo "Baza danych została pomyślnie utworzona pod nazwą $nazwa";
} else {
    echo "Błąd podczas tworzenia bazy danych: " . mysqli_error($conn);
}



$sql_use_db = "USE $nazwa";
mysqli_query($conn, $sql_use_db);

$sql_create_table = "CREATE TABLE $tabelanazwa (
    $pole1 varchar(255), 
    $pole2 varchar(255)
)";
if (mysqli_query($conn, $sql_create_table)) {
    echo "Dodano tabelę $tabelanazwa z dwoma polami: $pole1 i $pole2";
} else {
    echo "Błąd podczas tworzenia tabeli lub pól: " . mysqli_error($conn);
}


mysqli_close($conn);
?>