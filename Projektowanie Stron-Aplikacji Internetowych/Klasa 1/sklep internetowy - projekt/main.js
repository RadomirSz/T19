$(document).ready(function(){
    $('#exampleSelect').val('all');
    $('#exampleSelect').on('change', function() {
      var selectedOption = $(this).val();
    
      if (selectedOption === 'all') {
        $('.col-12').show();
      } else {
        $('.col-12').hide();
        if (selectedOption === 'volkswagen') {
          $('.volkswagen').show();
        } else if (selectedOption === 'audi') {
          $('.audi').show();
        } else if (selectedOption === 'opel') {
          $('.opel').show();
        } else if (selectedOption === 'Mercedes') {
          $('.mercedes').show();
        }else if (selectedOption === 'toyota') {
          $('.toyota').show();
        }
      }
      console.log(selectedOption);
    });
  });

biblioteka= [
{
  "img": "supragr.png",
"cena": 215000,
"marka": "Toyota",
"model": "Supra Gr",
"rokProdukcji": " 2021",
"konieMech": "340KM",
"przebieg": "83124km"
},
{
  "img": "opelcorsa.png",
  "cena": 57500,
  "marka": "Opel",
  "model": "Corsa",
  "rokProdukcji": "2022",
  "konieMech": "130KM",
  "przebieg": "80173km"
},
{
  "img": "mercedesklasaa.png",
  "cena": 110000,
  "marka": "Mercedes",
  "model": "Klasa A",
  "rokProdukcji": "2015",
  "konieMech": "360KM",
  "przebieg": "140934km"
},
{
  "img": "audir8.png",
  "cena": 550000,
  "marka": "Audi",
  "model": "R8 V10",
  "rokProdukcji": "2018",
  "konieMech": "602KM",
  "przebieg": "63840km"
},
{
  "img": "ArteonR.png",
  "cena": 200000,
  "marka": "Volkswagen",
  "model": "Arteon R",
  "rokProdukcji": "2021",
  "konieMech": "320KM",
  "przebieg": "32045m"
},
{
  "img": "mercedesklasac.png",
  "cena": 245000,
  "marka": "Mercedes",
  "model": "Klasa C",
  "rokProdukcji": "2021",
  "konieMech": "204KM",
  "przebieg": "25000km"
},
{
  "img": "corolla.jpg",
  "cena": 95000,
  "marka": "Toyota",
  "model": "Corolla",
  "rokProdukcji": "2017",
  "konieMech": "140KM",
  "przebieg": "35120km"
},
{
  "img": "audiq3.png",
  "cena": 110000,
  "marka": "Audi",
  "model": "Q3",
  "rokProdukcji": "2022",
  "konieMech": "150KM",
  "przebieg": "120673km"
},
{
  "img": "tcross.png",
  "cena": 75400,
  "marka": "Volkswagen",
  "model": "T-Cross",
  "rokProdukcji": "2019",
  "konieMech": "115KM",
  "przebieg": "46732km"
},
{
  "img": "audirs5.png",
  "cena": 225000,
  "marka": "Audi",
  "model": "RS 5 Coupé ",
  "rokProdukcji": "2018",
  "konieMech": "450KM",
  "przebieg": "94623km"
}
]
function kupno(index)
{
    sessionStorage.setItem("img", biblioteka[index].img);
    sessionStorage.setItem("cena", biblioteka[index].cena);
    sessionStorage.setItem("marka", biblioteka[index].marka);
    sessionStorage.setItem("model", biblioteka[index].model);
    sessionStorage.setItem("rokProdukcji", biblioteka[index].rokProdukcji);
    sessionStorage.setItem("konieMech", biblioteka[index].konieMech);
    sessionStorage.setItem("przebieg", biblioteka[index].przebieg);
    location.href="kupno.html";
}

function powrot()
{
  location.href = "index.html";
}


function OdczytajDane(){
  var img = sessionStorage.getItem("img");
  var cena = sessionStorage.getItem("cena");
  var marka = sessionStorage.getItem("marka");
  var model = sessionStorage.getItem("model");
  var rokProdukcji = sessionStorage.getItem("rokProdukcji");
  var konieMech = sessionStorage.getItem("konieMech");
  var przebieg = sessionStorage.getItem("przebieg");
  
  
  
  document.getElementById("img").src = img;
  document.getElementById("marka").innerHTML = marka;
  document.getElementById("model").innerHTML = model;
  document.getElementById("cena").innerHTML = (cena).concat(" zł");
 
  document.getElementById("rokProdukcji").innerHTML = rokProdukcji;
  document.getElementById("konieMech").innerHTML = konieMech;
  document.getElementById("przebieg").innerHTML = przebieg;
  
}

function formaplatnosci(){
  if(document.getElementById("naRaty").checked){
  document.getElementById("raty").style.display = "initial";
  document.getElementById("ratyLabel").style.display="initial";
  }
  else{
      document.getElementById("raty").style.display = "none";
      document.getElementById("ratyLabel").style.display = "none";
  }
}

function Zakup(){
  var marka = sessionStorage.getItem("marka");
  var model = sessionStorage.getItem("model");
  var sumaCen = sessionStorage.getItem("cena");
  var cenaDodatkow = sessionStorage.getItem("cenaDodatkow");
  var img = sessionStorage.getItem("img");
  sumaCen = parseInt(sumaCen) + parseInt(cenaDodatkow)

  var date = new Date();
  var dzien = date.getDate();
  var miesiac = date.getMonth() + 1;
  var rok = date.getFullYear();
  
  dzien += 7 + Math.floor(Math.random() * 7);
  if (dzien >= 31){
      dzien %= 31;
      miesiac += 1;
      if (dzien == 0) 
      {
        dzien += 1;
      }
  }
  
  var wiadomosc = (marka).concat(" ").concat(model);
  var czasOczekiwania = "Przewidywany czas dostarczenia auta: ".concat(dzien).concat(".").concat(miesiac).concat(".").concat(rok);
  var zaplata = "Ostateczna kwota: ".concat(sumaCen).concat(" zł");
  document.getElementById("wiadomosc").innerHTML = wiadomosc;
  document.getElementById("dostawa").innerHTML = czasOczekiwania;
  document.getElementById("zaplata").innerHTML = zaplata;
  document.getElementById("img").src = img;
}

function dokonca(){
    var FPlatnosci = document.querySelector('input[name = "formaPlatnosci"]:checked');
    var dane = document.getElementsByName("dane");
    var breaker = false;
    var check = undefined;

    if (FPlatnosci == null){
        breaker = true;
        check = 0;
    }
    
    for (var i = 0; i < dane.length; i++){
        if (dane[i].value == null || dane[i].value == "" && check == undefined) {
            breaker = true;
            check = 1;
        }
    }

    var cenaDodatkow = 0;
    var dodatki = document.getElementsByName("dodatki");
    for(var i = 0; i < dodatki.length; i++){
        if (dodatki[i].checked) cenaDodatkow += parseInt(dodatki[i].value);
    }
    sessionStorage.setItem("cenaDodatkow", cenaDodatkow);
    if (breaker) {
        if (check == 0) {
            alert("Proszę wybrać formę płatności!");
        }
        else if (check == 1) {
            alert("Proszę wypełnić dane osobowe!");
        }
        else if (check == undefined) {
            alert("Nie wiem jak ci się to udało");
        }
    } 
    else {
        location.href = "koniec.html";
    }
}

