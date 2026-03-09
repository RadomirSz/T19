<?php

if(isset($_POST['zgoda'])){
    $conn = mysqli_connect("localhost","root","","baza");
    $data = $_POST['data'];
    $ilosc = $_POST['ilosc'];
    $telefon = $_POST['telefon'];

    $query = "INSERT INTO rezerwacje VALUES(NULL,NULL, $data, $ilosc, $telefon);";
    mysqli_query($conn, $query);
    mysqli_close($conn);
    echo "Dodano rezerwację do bazy";
}


?>