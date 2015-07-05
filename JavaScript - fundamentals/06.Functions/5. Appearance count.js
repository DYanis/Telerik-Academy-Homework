function AppearanceCount(number,arr){
    var count = 0;
    for (var i = 0; i < arr.length; i++) {
        if(arr[i]== number){
            count+=1;
        }
    }
    return count;
}

function TestAppearanceCount(number,arr,currentResult){
    return AppearanceCount(number,arr) === currentResult;
}

console.log(AppearanceCount(7,[43,7,65,7,34,2,4,7,3,8,7,2,3,2]));
console.log(TestAppearanceCount(7,[43,7,65,7,34,2,4,7,3,8,7,2,3,2],4));