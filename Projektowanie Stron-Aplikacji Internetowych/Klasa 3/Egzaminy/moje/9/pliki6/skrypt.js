function funkcja(input) {
    if (input == 1) {
        document.getElementById("blok1").style.opacity = 0;
        document.getElementById("blok2").style.opacity = 1;
    } else if(input == 2) {
        document.getElementById("blok2").style.opacity = 0;
        document.getElementById("blok3").style.opacity = 1;
    }
    else if(input == 3){
        let haslo1 = document.getElementById('haslo').value;
        let haslo2 = document.getElementById('haslo2').value;
        if (haslo1 != haslo2) {
            alert("Podane hasła różnią się");
            return;
        }
        let imie = document.getElementById('imie').value;
        let nazwisko = document.getElementById('nazwisko').value;
        console.log("Witaj", imie, nazwisko);
    }
}