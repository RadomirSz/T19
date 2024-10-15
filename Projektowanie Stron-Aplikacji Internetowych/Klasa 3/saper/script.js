
var emotki = ["😊","🙃","☹️","😎","💣"]; // default - click - lose - win - bomb

function start() {
    change();
}

function change() {
    //$('#fieldSize').on('change', function() {change();});
    let size = $('#fieldSize').val();

    switch (size) {
        case 'small':
            $('#frame').css('width',"15vw");
            createField(8,10);
            break;
        case 'medium':
            $('#frame').css('width',"22vw");
            createField(12,22);
            break;
        case 'big':
            $('#frame').css('width',"28vw");
            createField(16,40);
            break;
        default:
            alert('Wybierz rozmiar planszy!');
            break;
    }
}
var board = $(".field");
function createField(fieldSize, mineCount) 
{
    board = $(".field");
    //var arrays = new Array();
    board.empty();
    for (var i = 0; i < fieldSize; i++) 
    {
        var row = $('<div>').addClass('row');
        for (var j = 0; j < fieldSize; j++) 
        {
            var col = $('<div>').addClass('col hidden');
            let number = (i+1) + "-" + (j+1);
            col.addClass(number);
            col.data('mine', false);
            col.data('flagged', false);

            //col.contextmenu(toggleFlag);
            
            row.append(col);
        }
        board.append(row);
    }

    for (var k = 0; k < mineCount; k++) {
        let flag = true;
        do 
        {
            var randomRow = Math.floor(Math.random() * fieldSize);
            var randomCol = Math.floor(Math.random() * fieldSize);
            let cell = "." + randomRow + "-" + randomCol;
            var randomCell = $(cell);
            if (!randomCell.data('mine')) 
            { 
                randomCell.data('mine', true);
                console.log(cell + " got a mine");
                flag = false;
            }
        } while (flag);
    }

}

board.on('click', '.col.hidden', function (){
    console.log("klik");
    if($(this).data('mine'))
    {
        console.log("klik z miną");
    }
})