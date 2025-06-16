function wyslij() {
    let tekst = document.getElementById('wiadomosc').value;
    let chat = document.getElementById('chat');
    let julkaDiv = document.createElement('div');
    julkaDiv.id = "wypowiedzJolanty";
    let julkaImg = document.createElement('img');
    julkaImg.src = 'Jolka.jpg';
    
    let julkaP = document.createElement('p');
    julkaP.textContent = tekst;

    julkaDiv.appendChild(julkaImg);
    julkaDiv.appendChild(julkaP);
    chat.appendChild(julkaDiv);
    
    chat.scrollIntoView();
}

var tablica = [
"Świetnie!",
"Kto gra główną rolę?",
"Lubisz filmy Tego reżysera?",
"Będę 10 minut wcześniej",
"Może kupimy sobie popcorn?",
"Ja wolę Colę",
"Zaproszę jeszcze Grześka",
"Tydzień temu też byłem w kinie na Diunie",
"Ja funduję bilety"
];

function losuj() {
    let losowaLiczba = Math.floor(Math.random()*tablica.length);

    let tekst = tablica[losowaLiczba];
    let krzysztofDiv = document.createElement('div');
    krzysztofDiv.id = "wypowiedzKrzysztofa";
    let krzysztofImg = document.createElement('img');
    krzysztofImg.src = 'Krzysiek.jpg';
    let krzysztofP = document.createElement('p');
    krzysztofP.textContent = tekst;
    
    krzysztofDiv.appendChild(krzysztofImg);
    krzysztofDiv.appendChild(krzysztofP);
    
    let chat = document.getElementById('chat');
    chat.appendChild(krzysztofDiv);
    chat.scrollIntoView();
}