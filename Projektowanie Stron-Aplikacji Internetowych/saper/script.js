
// var emotki = ["😊","🙃","☹️","😎","💣"]; // default - click - lose - win - bomb

function start() {
    
    let size = $('#fieldSize').val();

    switch (size) {
        case 'small':
            $('#frame').css('width',"15vw");
            createField(8,12);
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
    var mineCounter = mineCount;
    board = $(".field");
    //var arrays = new Array();
    board.empty();
    for (var i = 0; i < fieldSize; i++) 
    {
        var row = $('<div>').addClass('row');
        for (var j = 0; j < fieldSize; j++) 
        {
            let number = i + "-" + j;
            var col = $('<div>').addClass('col hidden empty');
            
            col.addClass(number);
            col.data('flagged', false);
            col.data("id", number);
            col.text("0");
            
            row.append(col);
        }
        board.append(row);
    }

    for (var k = 0; k < mineCount; k++) {
        // let flag = true;
        // do 
        // {
            var randomRow = Math.floor(Math.random() * fieldSize);
            var randomCol = Math.floor(Math.random() * fieldSize);
            let cell = "." + randomRow + "-" + randomCol;
            var randomCell = $(cell);
            // if (!randomCell.hasClass('mine')) 
            // { 
            randomCell.addClass('mine');
            randomCell.css('background-color',"red");
            randomCell.removeClass("empty");
                //console.log(cell + " got a mine");
                // flag = false;
            // }
        // } while (flag);
    }// Honestly i don't think checking if there is already a mine is necessary 
     // since the chance of it colliding is really low and even if one div got 
     // a mine 2 times nothing happens, there's just a bomb less. But yes, 
     // there is a chance of one bomb in the whole field | checking anyways isnt working idk why xd
    
    let sum = 0;
    for (let a = 0; a < fieldSize; a++) 
    {
        for (let b = 0; b < fieldSize; b++) 
        {
            // my cell
            let currentCell = "." + (a) + "-" + (b);
            if($(currentCell).hasClass("mine")) continue;
            //console.log(a +" " + b + " " + currentCell);
            
            // cells around it
            let leftup = "." + (a-1) + "-" + (b-1);
            if($(leftup).hasClass('mine'))
            {
                sum++;
            }
            let midup = "." + (a) + "-" + (b-1);
            
            if($(midup).hasClass('mine'))
            {
                sum++;
            }
            let rightup = "." + (a+1) + "-" + (b-1);
            if($(rightup).hasClass('mine'))
            {
                sum++;
            }
            let leftmid = "." + (a-1) + "-" + (b);
            if($(leftmid).hasClass('mine'))
            {
                sum++;
            }
            let rightmid = "." + (a+1) + "-" + (b);
            if($(rightmid).hasClass('mine'))
            {
                sum++;
            }
            let leftbottom = "." + (a-1) + "-" + (b+1);
            if($(leftbottom).hasClass('mine'))
            {
                sum++;
            }
            let midbottom = "." + (a) + "-" + (b+1);
            if($(midbottom).hasClass('mine'))
            {
                sum++;
            }
            let rightbottom = "." + (a+1) + "-" + (b+1);
            if($(rightbottom).hasClass('mine'))
            {
                sum++;
            }
            $(currentCell).removeClass("empty");
            switch (sum) 
            {
                case 1:
                    $(currentCell).addClass("one");
                    $(currentCell).text("1");
                    break;
                case 2:
                    $(currentCell).addClass("two");
                    $(currentCell).text("2");
                    break;
                case 3:
                    $(currentCell).addClass("three");
                    $(currentCell).text("3");
                    break;
                case 4:
                    $(currentCell).addClass("four");
                    $(currentCell).text("4");
                    break;
                case 5:
                    $(currentCell).addClass("five");
                    $(currentCell).text("5");
                    break;
                case 6:
                    $(currentCell).addClass("six");
                    $(currentCell).text("6");
                    break;
                case 7:
                    $(currentCell).addClass("seven");
                    $(currentCell).text("7");
                    break;
                case 8:
                    $(currentCell).addClass("eight");
                    $(currentCell).text("8");
                    break;
            
                default:
                    continue;
            }
            sum = 0;
        }  
    }


}

board.on('click', '.col.hidden', function (){
    if($(this).hasClass('mine'))
    {
        gameOver(false);
    }
    else
    {
        reveal($(this));
        const isGameOver = $(".col.hidden").length === 12;
        if(isGameOver){gameOver(true);}
    }
})

function gameOver(outcome) {
    let message = "";
    if(outcome)
    {
        message = "YOU WON!";
    }
    else
    {
        message = "YOU LOST";
    }   
    alert(message)
    start();
}

function reveal(object) {
    if(object.hasClass("hidden"))
    {
        object.removeClass("hidden");
        object.addClass("revealed");
    }
    let a = object.data('id').split('-')[0];
    let b = object.data('id').split("-")[1];
    let leftup = "." + (a-1) + "-" + (b-1);
    let midup = "." + (a) + "-" + (b-1);
    let rightup = "." + (a+1) + "-" + (b-1);
    
    let leftmid = "." + (a-1) + "-" + (b);
    let rightmid = "." + (a+1) + "-" + (b);
    
    let leftbottom = "." + (a-1) + "-" + (b+1);
    let midbottom = "." + (a) + "-" + (b+1);
    let rightbottom = "." + (a+1) + "-" + (b+1);

    if(!$(leftup).hasClass('mine'))
    {
        reveal($(leftup));
    }
    if(!$(midup).hasClass('mine'))
    {
        reveal($(midup));
    }
    if(!$(rightup).hasClass('mine'))
    {
        reveal($(rightup));
    }
    if(!$(leftmid).hasClass('mine'))
    {
        reveal($(leftmid));
    }
    if(!$(rightmid).hasClass('mine'))
    {
        reveal($(rightmid));
    }
    if(!$(leftbottom).hasClass('mine'))
    {
        reveal($(leftbottom));
    }
    if(!$(midbottom).hasClass('mine'))
    {
        reveal($(midbottom));
    }
    if(!$(rightbottom).hasClass('mine'))
    {
        reveal($(rightbottom));
    }
}