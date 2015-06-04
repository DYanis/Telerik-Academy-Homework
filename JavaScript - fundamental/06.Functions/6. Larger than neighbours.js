function LargerThanNeighbours(index,array){
    return (array[index] > array[index-1] && array[index] > array[index+1]);
}

var result = LargerThanNeighbours(4,[21,32,42,1,5,0]);
console.log(result);