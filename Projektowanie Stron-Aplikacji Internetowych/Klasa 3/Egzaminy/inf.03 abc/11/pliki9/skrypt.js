var obecneZdjecie = 1;
function zmienZdjecie(input) {
    if(input == -1){
        if(obecneZdjecie == 1) obecneZdjecie = 7;
        else obecneZdjecie--;
        document.getElementById('aktywne').src = obecneZdjecie +".jpg";
    }
    else if(input == 1){
        if(obecneZdjecie == 7) obecneZdjecie = 1;
        else obecneZdjecie++;
        document.getElementById('aktywne').src = obecneZdjecie +".jpg";
    }
}