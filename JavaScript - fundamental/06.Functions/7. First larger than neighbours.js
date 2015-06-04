function LargerThanNeighbours(index,array){
    return (array[index] > array[index-1] && array[index] > array[index+1]);
}

function FirstLargerThanNeighbours(arr){
    for (var i = 1; i < arr.length-1; i++) {
        if(LargerThanNeighbours(i,arr)){
            return i;
        }
    }
    return -1;
}

var result = FirstLargerThanNeighbours([2,-4,2,4,32,54,12,32,54]);
console.log(result);
