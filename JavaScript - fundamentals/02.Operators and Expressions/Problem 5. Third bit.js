var decimalNumber = Number(prompt('Please add number'));
var binNumber = decimalNumber.toString(2);

var result = binNumber[binNumber.length-4];
if(result === 1) {
    console.log(result);
}
else{
    console.log(0);
}