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