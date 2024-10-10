var zdjecia = Array(
    Array('obraz1.jpeg', 'obraz1.jpeg', "Góry", "Góry z jeziorami"),
    Array('obraz2.webp', 'obraz2.webp', "Kot", "kitek"),
    Array('obraz3.jpeg', 'obraz3.jpeg', "żaglówka", "sobie płyną"),
    Array('obraz4.webp', 'obraz4.webp', "żaglówka v2", "ale woda spokojna"),
    Array('obraz5.jpeg', 'obraz5.jpeg', "żaglówka v1.2", "też sobie szybko płyną"),
    Array('obraz6.jpeg', 'obraz6.jpeg', "wakacje (żaglówka v2.2)", "wypoczynek na żaglówce")
);

var max_width = 520;

function laduj() {
    for(var i = 0; i < zdjecia.length; i++)
        document.getElementById('miniaturki').innerHTML += '<img src="' + zdjecia[i][1] + '" onclick="zmien(' + i + ')" />';
    zmien(0);
}

function zmien(id) {
    document.getElementById('zdjecie').innerHTML += '<div id="ladowanie"></div>';
    var custom = '';
    var preload = new Image();
    preload.onload = function() {
        if(preload.width > max_width)
            custom = ' style="height: '+(Math.floor(max_width / (preload.width / preload.height)))+'px;width:'+max_width+'px;"';

        document.getElementById('informacje').innerHTML = '<b>'+zdjecia[id][2]+'</b><br /><i>'+zdjecia[id][3]+'</i>';
        document.getElementById('zdjecie').innerHTML = '<img src="'+zdjecia[id][0]+'"'+custom+' />';
    }
    preload.src = zdjecia[id][0];
}

window.onload = laduj;
