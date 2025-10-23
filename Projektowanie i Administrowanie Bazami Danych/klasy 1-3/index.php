<?PHP
//phpinfo();
echo "test coś tam łączenie z bazą danych MySQL"."<br>"."<br>"."test";

$serwer = "localhost";
$uzytkownik = "root";
$haslo = "";

$baza = "przepisyPrzyklad";
$baza2 = "ptaki";
$baza3 = "agencjaartystycznaprzyklad";

$con = new mysqli($serwer,$uzytkownik,$haslo,$baza);
$con2 = new mysqli($serwer,$uzytkownik,$haslo,$baza2);
$con3 = new mysqli($serwer,$uzytkownik,$haslo,$baza3);

$zapytanie="SELECT NazwaPrzepisu FROM przepisy ORDER BY NazwaPrzepisu DESC";

$zapytanie2="SELECT nazwa_zwyczajowa From gatunki";

$zapytanie3="SELECT NazwaScenicznaWykonawcy From wykonawcy";

if($wynik=$con->query($zapytanie)){

while ($row=$wynik->fetch_array()){
    echo $row["NazwaPrzepisu"]."<br>";
}

}
else{
    echo $con->errno." ".$con->error;
}
if($wynik=$con2->query($zapytanie2)){

    while ($row2=$wynik->fetch_array()){
    
    echo $row2["nazwa_zwyczajowa"]."<br>";
    
    }
    
    }
    else{
    
    echo $con2->errno." ".$con2->error;
    
    }

$con2->close();

if($wynik=$con3->query($zapytanie3)){

    while ($row3=$wynik->fetch_array()){
    
    echo $row3["NazwaScenicznaWykonawcy"]."<br>";
    
    }
    
    }
    else{
    
    echo $con3->errno." ".$con3->error;
    
    }

$con3->close();

?>