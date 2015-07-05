
var pointX = Math.abs((prompt('Please add X')));
var pointY = Math.abs((prompt('Please add Y')));
console.log(pointX + pointY);
var distance=Math.sqrt((0) + Math.pow((pointX + pointY), 2)) ;

if(distance<=5){
    console.log(true);
}else{

    console.log(false);
}