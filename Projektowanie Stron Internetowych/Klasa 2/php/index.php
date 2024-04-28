<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <!-- <p>siema</p>
    <form action="php.php" method="post">
        <input type="text" name="login" id="login" placeholder="login">
        <input type="text" name="haslo" id="haslo" placeholder="haslo">
        <input type="submit">
    </form> -->

    <form method="post">
           haslo: <input type="text" name="haslo">
            login: <input type="text" name="login">
                <input type="submit" value="Wyślij">
    </form>
    
<?php
error_reporting(0);

$login = $_POST["login"];
$haslo = $_POST["haslo"];

 printf("dales haslo: ".$haslo."   i login: ".$login);

 printf("<br>time (sekundy od 1970.01.01): ".time());
 printf("<br>teraz (date): ".date('d.m.Y H:i:s'));
 printf("<br>teraz (date r): ".date('r'));
 printf("<br>teraz (date małe L): ".date('l'));

 $data = getdate();

 printf("<br>getdate: ".$data['year']);
 printf("<br>getdate: ".$data['hour']);
 printf("<br>getdate: ".$data['month']);
 printf("<br>getdate: ".$data['seconds']);

 if(isset($login)) {
    printf("<br>jest login zadefiniowany ");
 }
 if(empty($login))
 {
    printf("<br>ale nie ma wartości");
 }
 unset($login); // bu
 if(!isset($login)) {
    printf("<br>teraz nie jest login zadefiniowany ");
 }
 if(!isset($skibidi))
 {
    printf("<br>nie jest nieisniejaca zmienna zadefiniowana");
 }
 print("<br>");

 // nl2br daje <br> po każdym bloku tesktu / nie dziala xd / no nie idzie
 print( nl2br('ala kota ni
  ma t
   am'));

 //wordwrap zawija w kolumny  wordwrap($zmiennaTekst , dlugoscLinii , co potem np. "<br>\n")
 print("<br>");
 $tekst = "bbbbbbbbbbbbbbbbbbbbbbbbbbbb bbbbbbbbbbbbbbbbbbbbbbbb bbbbbbbbb bbb bbw ww www wwwwwwwwwwwwwww wwwwwwwwwwww wwwwwwwwwwww";
 printf( wordwrap($tekst , 10 ,'<br>'));

 //trim usuwa spacje z lewej i prawej  / jest jeszcze ltrim i rtrim 
 echo("<br>");
 echo trim("                 tekst   ");

 // ucfirst() - pierwsza litera na wielką
 //strtoupper()
 //strtolower()
 //strlen() dlugosc
 //substr("string",poczatek,koniec)
 //str_replace("podmieniany","na ten", "w tym napisie")
 //strstr("w tym napisie", "jak znajdzie to") to wyświetla od znalezionego do końca
 //pi()
 //pow(podstawa,wykladnik) potega
 //sqrt() pierwiastek
 //getrandmax() maksymalna liczba generowana przez rand
 //rand(min,max) randomowa


 //mail($adres,$naglowek,$temat,$tresc);

// error_reporting(0);
//     $haslo = $_POST['haslo'];
//     $login = $_POST['login'];
//     if (empty($haslo) || empty($login)) printf("Nie masz imienia");
//     else printf("<div id='title'>" . "haslo: " . $haslo . " login:" . $login . " </div>");

?>
</body>
</html>
