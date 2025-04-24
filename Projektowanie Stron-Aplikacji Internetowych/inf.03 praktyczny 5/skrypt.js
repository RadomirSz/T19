function funkcja() {
    let wynik = 0;
    let boxy = document.getElementsByName("pola");
    for (let index = 0; index < 4; index++) {
        const element = boxy[index].checked;
        if(element){
            switch (index) {
                case 0:
                    wynik += 45;
                    break;
                case 1:
                    wynik += 30;
                    break;
                case 2:
                    wynik += 20;
                    break;
                case 3:
                    wynik += 50;
                    break;
            }
        }
    }   
    document.getElementById("wynik").innerHTML = "Cena zabiegów:" + wynik;
}