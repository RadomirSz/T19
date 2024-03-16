function test(){
alert("witam");
}

function mnozenie()
{
    a = prompt("podaj liczbe","");
    b = prompt("podaj liczbe","");
    alert("pomnożone dają:" + a*b);
}

function DIVIDE()
{
    a = prompt("podaj liczbe","");
    b = prompt("podaj liczbe","");
    alert("pomnożone dają:" + a/b);
}

function suma()
{
    a = prompt("podaj liczbe","");
    b = prompt("podaj liczbe","");
    alert("ich suma to: " + a-+-b);

}

function odejmowanie()
{
    a = prompt("podaj liczbe","");
    b = prompt("podaj liczbe","");
    alert("ich różnica to: " + a-b);

}

function nan()
{
    let a = prompt("podaj liczbe","");
    let b = prompt("podaj liczbe","");
    let wynik = (a*b)? a*b:a*b;
    let metoda = (isNaN(wynik))?
    "tylko liczby podawaj ":
    "iloczyn liczb wynosi: "+wynik;
    alert(metoda);
}

function pisz()
{
    document.write("hejo");
    document.write("<br><b>witaj</b><br>");
    document.write('<input type="button" onClick="mnozenie()" value="pomnożę">');

}

function iff()
{
    let a = prompt("podaj liczbe","");
    if(a>9) {alert("to nie cyfra");}
    if(a<10 && a>-1) {alert("to cyfra");}
}
let loginP;
let passwordP;
function tworz()
{
    loginP = prompt("utworz login: ","")
    passwordP = prompt("utworz hasło: ","")
}

function  login()
{
    let login = prompt("Podaj login: ","")
    let password = prompt("Podaj hasło: ","")
    if(login==loginP && password==passwordP)
    {
        document.write("<body><h1>siema dobre hasło podałeś</h1></body>");
    }
    else
    {
        alert("zły login lub hasło");
    }
    
}

function szyfrowanie()
{
    let litera = prompt("podaj jeden znak do zaszyfrowania","")
    alert(litera.charCodeAt(0))
}


function szyfrbar()
{
    let loginB = prompt("Podaj login: ","")
    let passwordB = prompt("Podaj hasło: ","")
    let haslo=password.charCodeAt(0);
    if(login=="admin" && haslo==56)
    {
        document.write("łał okok")
    }
    else
    [
        alert("zly login lub haslo")
    ]

}

function wypadki()
{
    switch(prompt("podaj imię: ", ""))
    {
        case "Radomir":
            alert("w bolierze nie ma żadnej bobmy")
            break;
        case "Kacper":
            alert("zobaczymy jak bomba pierdolnie")
            break;
        default:
            alert("bajo jajo")
            break;
    }
}

function wyliczanie()
{
    let temp = "";
    for(i=0;i<10;i++)
    {
        document.write(i + "<br>");
        temp += i + "\n";
    }
    alert(temp);

    document.write("<br>");
    let j = 10;
    
    while(j>0){document.write(j + "<br>"); j--;}
    
    let d = 0;
    do{
        document.write("miłego dnia :D <br>");
        d++;   
    }
    while(d<101)
}

function potegi()
{
    let p = prompt("liczba: ","");
    let w = prompt("potęga: ","");
    let liczba = p;
    for(let i=0;i<w-1;i++)
    {
        liczba = liczba * p;
    }
    alert(liczba);
}