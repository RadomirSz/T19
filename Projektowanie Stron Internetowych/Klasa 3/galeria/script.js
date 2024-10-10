let zdjecia = 
["obraz1.jpeg","obraz2.webp"]

let indeks = 0;
function funkcja(index) {
    if (index < 0) {
        indeks = zdjecia.length - index;
    }
    else{
    indeks = Math.abs(index) % zdjecia.length;
    }
    document.getElementById("photo").setAttribute("src",zdjecia[indeks]);
}