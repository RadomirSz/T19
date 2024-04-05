<?php

    $a = $_POST['liczba1'];
    $b = $_POST['liczba2'];
    $c = $_POST['liczba3'];

    printf($a."<br>");
    printf($b."<br>");
    printf($c."<br>");

    $delta = pow($b,2) - (4 * $a * $c);
    printf("delta: ".$delta."<br>");
    if($delta <= 0) 
    {
        printf("nie ma rozwiązania");
    }
    else{
        $x = (-$b + sqrt($delta)) / (2*$a);
       $x2 = (-$b - sqrt($delta)) / (2*$a);
        printf($x."<br>");
        printf($x2."<br>");
    }
?>