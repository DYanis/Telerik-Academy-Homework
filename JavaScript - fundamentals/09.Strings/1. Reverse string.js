function Reverse (input){
    var result = '';
    for (var i = 0; i < input.length; i++) {
        result = input[i]+result;

    }
    return result;
}

console.log(Reverse(('sample')));