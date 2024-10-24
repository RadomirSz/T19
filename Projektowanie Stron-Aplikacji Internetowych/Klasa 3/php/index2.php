<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
<form method="post">
    <input type="text" name="n" id="n">
    <input type="submit" value="Wyślij">
</form>

<?php

$n = $_POST["n"];

$lista_pierwszych = array();

for ($i=0; $i < $n+1; $i++) { 
    $lista_pierwszych[$i] = True;
}

$p = 2;

while ($p*$p <= $n)
{
    if ($lista_pierwszych[$p])
    {
        for ($j=$p*$p; $j < $n+1; $j += $p) { 
            $lista_pierwszych[$j] = False;
        }
    }
    $p += 1;
}

for ($a=2; $a < $n; $a++) {
    if ($lista_pierwszych[$a]) {
        echo($a . " ");
    }
}

?>
</body>
</html>