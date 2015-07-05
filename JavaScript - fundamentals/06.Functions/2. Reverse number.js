function ReverseNumber(number){
    var number = number.toString(),
        result = '';
    for (var i = number.length-1; i >= 0; i-=1) {
        result += number[i];

    }
    return result;
}

console.log(ReverseNumber(123.45));