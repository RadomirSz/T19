<?php

$host = 'localhost'; // Host bazy danych
$username = 'root'; // Nazwa użytkownika bazy danych
$password = ''; // Hasło bazy danych
$database = 'ksiegarnia'; // Nazwa bazy danych


$conn = new mysqli($host, $username, $password, $database);

$sql = "SELECT imie, nazwisko, miejscowosc FROM klienci";

if ($conn->connect_error) {
    die("Błąd połączenia z bazą danych: " . $conn->connect_error);
}

$result = $conn->query($sql);


if ($result->num_rows > 0) {
    // Przetwarzanie wyników
    while($row = $result->fetch_assoc()) {
        echo $row["imie"]. " " . $row["nazwisko"]. "z" . $row["miejscowosc"];
    }
} else {
    echo "Brak wyników";
}

$conn->close();
?>





<?php
$servername = "localhost";
$username = "root";
$password = "";
$conn = mysqli_connect($servername, $username, $password);
if (!$conn) {
    die("Połączenie nieudane: " .mysqli_connect_error());
}
$sql = "CREATE DATABASE testDB; create table klasy (id int primary key auto_increment, klasa varchar(10));";
if (mysqli_query($conn, $sql)) {
    echo "Baza danych została pomyślnie utworzona pod nazwą testDB";
} else {
    echo "Błąd podczas tworzenia bazy danych: " . mysqli_error($conn);
}
mysqli_close($conn);
?>

