
var emotki = ["😊","🙃","☹️","😎","💣"]; // default - click - lose - win - bomb

function start() {
    $('#startButton').attr
}
function changeSize() {
    fieldSize = parseInt($("#fieldSize").val());
    
  }

function change() {
    //$('#fieldSize').on('change', function() {change();});
    let size = $('#fieldSize').val();

    switch (size) {
        case 'small':
            createField(8,10);
            break;
        case 'medium':
            createField(12,22);
            break;
        case 'big':
            createField(16,40);
            break;
        default:
            alert('Wybierz rozmiar planszy!');
            break;
    }
    start();
}

function createField(fieldSize, mineCount) 
{
  var board = $(".field");
  var arrays = new Array();

for (var i = 0; i < fieldSize; i++) {
    var row = $('<div>').addClass('row');
    var newarray = new Array();
    for (var j = 0; j < fieldSize; j++) {
        var col = $('<div>').addClass('col').addId(i +"-"+ j);
        
        
        cell.data('revealed', false);
        cell.data('flagged', false);
        cell.text("");
        cell.click(revealCell);
        cell.contextmenu(toggleFlag);
        
        newarray.append(false);
        row.append(col);
    }
    board.append(row);
    arrays.append(newarray);
}

for (var k = 0; k < mineCount; k++) {
    let flag = true;
        do {
        var randomRow = Math.floor(Math.random() * fieldSize);
        var randomCol = Math.floor(Math.random() * fieldSize);
        let cell = "." + randomRow + "-" + randomCol;
        var randomCell = $(cell);
        if (!randomCell.data('mine')) { 
            randomCell.data('mine', true);
            flag = false;
        }
    } while (flag);
}

}