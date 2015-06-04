var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    curentNumber,
    minNumber = arr[0];

for (var i = 0; i < arr.length; i++) {
    curentNumber = arr[i];

    for (var j = i; j < arr.length; j++) {

        if(arr[j]< minNumber){
            minNumber = arr[j];
        }
    }
   arr[arr.indexOf(i,minNumber)] = arr[i];
   arr[i] = minNumber;
}

console.log(arr);
