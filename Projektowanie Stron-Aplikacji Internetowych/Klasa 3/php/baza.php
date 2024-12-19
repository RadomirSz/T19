<?php
$servername = "localhost";
$username = "root";
$password = "";
$conn = mysqli_connect($servername, $username, $password);
if (!$conn) {
    die("Połączenie nieudane: " .mysqli_connect_error());
}
$sql = "CREATE DATABASE testDB3";
if (mysqli_query($conn, $sql)) {
    echo "Baza danych została pomyślnie utworzona pod nazwą testDB";
} else {
    echo "Błąd podczas tworzenia bazy danych: " . mysqli_error($conn);
}
mysqli_close($conn);
?>
