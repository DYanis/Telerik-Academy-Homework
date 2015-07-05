Array.prototype.remove = function(element){
    var result = [];
    for (var i = 0; i < this.length; i++) {
        if(this[i] !== element){
            result.push(this[i])
        }
    }
    return result;
};

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
console.log(arr.remove(1)); //arr = [2,4,3,4,111,3,2,'1'];