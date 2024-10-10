let zdjecia = 
["obraz1.jpeg","obraz2.webp","obraz3.jpeg","obraz4.webp","obraz5.jpeg","obraz6.jpeg"]

let indeks = 0;
function funkcja(index) {
    indeks = index;
    if (indeks === -1) indeks = zdjecia.length - 1;
    let outindex = indeks % zdjecia.length;
    document.getElementById("photo").setAttribute("src",zdjecia[outindex]);
}