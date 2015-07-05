var count = 1,
    maxCount = 1,
    curentNumber;

   var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
   var maximalSequenceNumber = arr[0];
for (var i = 0; i < arr.length-1; i++) {
    curentNumber = arr[i];
    if(arr[i] === arr[i+1]){
        count += 1;
        if(maxCount < count){
            maxCount=count;
            maximalSequenceNumber = curentNumber;
        }
    }else{
        count = 1;
    }
}
var result = [];
for (var i = 0; i < maxCount; i++) {
    result.push(maximalSequenceNumber);

}
console.log(result);