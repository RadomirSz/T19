function transform1() {
    let radios = document.getElementsByName("radio");
    let obrazek = document.getElementById("img1");
    let opcja;
    radios.forEach(radio =>{
        if(radio.checked){
            opcja = radio.id;
        }
    });
    switch (opcja) {
        case "blur":
            obrazek.style.filter = "blur(5px)";
            break;
        case "sepia":
            obrazek.style.filter = "sepia(100%)";
            break;
        case "negatyw":
            obrazek.style.filter = "invert(100%)";
            break;
    }
}
function transform2(opcja) {
    let obrazek = document.getElementById("img2");

    if(opcja == 1){
        obrazek.style.filter = "none";
    }
    else if(opcja == 2){
        obrazek.style.filter = "grayscale(100%)";
    }
}
function transform3() {
    let obrazek = document.getElementById("img3");
    let wartoscZasiegu = document.getElementById("range1");
    obrazek.style.filter = `opacity(${wartoscZasiegu.value}%)`;
}
function transform4() {
    let obrazek = document.getElementById("img4");
    let wartoscZasiegu = document.getElementById("range2");
    obrazek.style.filter = `brightness(${wartoscZasiegu.value}%)`;
}