function ukryj() {
    document.getElementById('blok1').style.display = "none";
    document.getElementById('blok2').style.display = "none";
    document.getElementById('blok3').style.display = "none";
}

function aktywuj(blok) {
    switch (blok) {
        case 1:
            ukryj();
            document.getElementById('blok1').style.display = "block";
            break;
        case 2:
            ukryj();
            document.getElementById('blok2').style.display = "block";
            break;
        case 3:
            ukryj();
            document.getElementById('blok3').style.display = "block";
            break;
        default:
            ukryj();
            document.getElementById('blok1').style.display = "block";
            break;
    }
}

function zatwierdz() {
    let out = "";
    let tab = document.getElementsByName('dane');
    tab.forEach(element => {
        out += element.value + ", ";
    });
    console.log(out);
}

let postepWartosc = 0;
function pasek() {    
    if (postepWartosc < 100) {
	    postepWartosc += 12;
	    if (postepWartosc > 100) {
	        postepWartosc = 100;
	    }
	    document.getElementById('progressbar').style.width = postepWartosc + '%';
	}
}
