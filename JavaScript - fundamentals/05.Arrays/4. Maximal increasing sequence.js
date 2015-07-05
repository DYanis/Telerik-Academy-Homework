var arr = [3, 2, 3, 1, 1, 6, 74],
    currentSequence = [0],
    maxSequence = [0];

for (var i = 0; i < arr.length-1; i++) {

   if(arr[i] <= arr[i+1]){
       currentSequence.push(arr[i+1]);
       if(currentSequence.length > maxSequence.length){
           maxSequence = currentSequence;
       }
   }else{
       currentSequence = [];
       currentSequence.push(arr[i+1])
   }
}
console.log(maxSequence);

