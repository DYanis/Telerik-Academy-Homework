function classCount(){
    var x = document.getElementsByClassName('item');
    var count = 0;
    for (var elem in x)
    {
        count+=1;
    }
    return count;
}
console.log(classCount());
