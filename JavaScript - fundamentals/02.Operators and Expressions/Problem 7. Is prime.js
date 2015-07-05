
var number = prompt('number?');

var isPrime=true;
if (number < 2) {
    isPrime= false
}


for (var i = 2; i <= Math.sqrt(number); i+=1) {

        if (number%i===0){
            isPrime=false;
        }

}

console.log(isPrime);
