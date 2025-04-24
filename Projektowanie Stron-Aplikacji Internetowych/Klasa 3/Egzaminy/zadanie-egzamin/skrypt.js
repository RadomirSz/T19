function resetuj() {
    document.getElementById("imie").value = "";
    document.getElementById("nazwisko").value = "";
    document.getElementById("email").value = "";
    document.getElementById("zgloszenie").value = "";
}

function wyslij() {
    let imie = document.getElementById("imie").value;
    let nazwisko = document.getElementById("nazwisko").value;
    let email = document.getElementById("email").value;
    let zgloszenie = document.getElementById("zgloszenie").value;
    let czyZapoznany = document.getElementById("zapoznany").checked;

    const wiadomosc = document.getElementById("wiadomosc");
    if (!czyZapoznany) {
        wiadomosc.style.color = "red";
        wiadomosc.innerHTML = "Musisz zapoznać się z regulaminem";
    }
    else {
        wiadomosc.style.color = "navy";
        wiadomosc.innerHTML = imie.toUpperCase() + " " + nazwisko.toUpperCase() + "<br>Treść Twojej sprawy: " + zgloszenie;
    }
}