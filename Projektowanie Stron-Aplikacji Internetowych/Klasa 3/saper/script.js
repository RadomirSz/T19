
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
var getFieldSize = 0;
var getMineCounter = 0;
function createField(fieldSize, mineCount) 
{
    getFieldSize = fieldSize;
    getMineCounter = mineCount;

    board = $(".field");
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
            col.data("i", i);
            col.data("j", j);
            col.text("0");
            col.attr("data-col",j);
            col.attr("data-row",i);

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
            if (!randomCell.hasClass('mine')) 
            { 
                randomCell.addClass('mine');
                //randomCell.css('background-color',"red");
                randomCell.removeClass("empty");
                console.log(cell + " got a mine");
                flag = false;
            }
        } while (flag);
    }
    
    let sum = 0;
    for (let a = 0; a < fieldSize; a++) 
    {
        for (let b = 0; b < fieldSize; b++) 
        {
            sum = 0;

            let currentCell = "." + (a) + "-" + (b);
            if($(currentCell).hasClass("mine")) continue;

            let leftup = "." + (a-1) + "-" + (b-1);
            let midup = "." + (a) + "-" + (b-1);
            let rightup = "." + (a+1) + "-" + (b-1);
            let leftmid = "." + (a-1) + "-" + (b);
            let rightmid = "." + (a+1) + "-" + (b);
            let leftbottom = "." + (a-1) + "-" + (b+1);
            let midbottom = "." + (a) + "-" + (b+1);
            let rightbottom = "." + (a+1) + "-" + (b+1);


            if($(leftup).hasClass('mine')) sum++;
            
            if($(midup).hasClass('mine')) sum++;
            
            if($(rightup).hasClass('mine')) sum++;

            if($(leftmid).hasClass('mine')) sum++;
         
            if($(rightmid).hasClass('mine')) sum++;
        
            if($(leftbottom).hasClass('mine')) sum++;
         
            if($(midbottom).hasClass('mine')) sum++;
        
            if($(rightbottom).hasClass('mine')) sum++;
          
            if(!(sum === 0)) $(currentCell).removeClass("empty");
            
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
    let i = $(this).data("i");
    let j = $(this).data("j");
        reveal(i,j);
        const isGameOver = $(".col.hidden").length === getMineCounter;
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


function reveal(oi, oj) {
    const seen = {};
    
    function helper(i, j) {
      if (i >= getFieldSize || j >= getFieldSize || i < 0 || j < 0) return;
      const key = `${i} ${j}`
      if (seen[key]) return;
      const $cell = $(`.col.hidden[data-row=${i}][data-col=${j}]`);
      const mineCount = getMineCount(i, j);
      if (mineCount) return;
      
      if (!$cell.hasClass('hidden') || $cell.hasClass('mine')) return;

      $cell.removeClass('hidden');
      $cell.addClass('revealed');
      
      for (let di = -1; di <= 1; di++) {
        for (let dj = -1; dj <= 1; dj++) {
          helper(i + di, j + dj);
        }      
      }
    }
    helper(oi, oj);
  }
  
  function getMineCount(i, j) {
    let str = "."+ i + "-" + j;
    let obj = $(str);
    if(obj.hasClass('one')) return 1;
    if(obj.hasClass('two')) return 2;
    if(obj.hasClass('three')) return 3;
    if(obj.hasClass('four')) return 4;
    if(obj.hasClass('five')) return 5;
    if(obj.hasClass('six')) return 6;
    if(obj.hasClass('seven')) return 7;
    if(obj.hasClass('eight')) return 8;
    return 0;
}