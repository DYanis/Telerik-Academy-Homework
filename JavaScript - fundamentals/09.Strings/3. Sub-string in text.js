function countSubstring (sequance,word){
    var count = 0;
    for (var i = 0; i < sequance.length; i++) {
        if(sequance[i]+sequance[i+1]===word){
            count+=1;
        }
    }
    console.log(count);
}
countSubstring("The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.",'in');