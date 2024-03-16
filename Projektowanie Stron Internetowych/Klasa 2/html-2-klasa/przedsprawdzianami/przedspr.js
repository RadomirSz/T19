function funkcja()
{
    alert("siema");
    document.write("bu");
}
function dzialania()
{
    let a = prompt("daj a","");
    let b = prompt("daj a","");
    alert(a-+-b);
}

function nan()
{
    let a = prompt("daj a","");
    if(isNaN(a))
    {alert("nie liczba")}
    else
    {alert("liczba")}
}

function charcode()
{
    let litera = prompt("podaj jeden znak do zaszyfrowania","")
    alert(litera.charCodeAt(0))
}
// do{} while() switch case'': break; default break;

function zadaniepow()
{
    let a = prompt("daj coś","");

    if(isNaN(a)) alert("nie numer (a)");
    else alert("numer (a)"); 

    let b = prompt("daj coś","");

    if(isNaN(b)) alert("nie numer (b)");
    else alert("numer (b)");
}

function potwierdz()
{
    let huj = confirm("CIASTECZKA");
    if(huj) alert("witamy");
    else alert(":( nie chcesz ciasteczek?");
}