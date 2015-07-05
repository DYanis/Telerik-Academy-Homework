function CountWord (text,word,caseSensitive){
    var words = text.split(/[\s,]+/),
        count = 0;

    if(arguments.length === 2){
        for (var i = 0; i < words.length; i++) {
           if(words[i]===word){
               count+=1;
           }

        }

    }else if(arguments.length === 3){
        for (var i = 0; i < words.length; i++) {
            if(words[i].toUpperCase()===word.toUpperCase()){
                count+=1;
            }

        }
    }
    return count;
}

text = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and " +
    "I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, th" +
    "e master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because" +
    " those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there " +
    " how who loves or pursues or desires to obtain pain of how itself, because it is pain, but because occasionally circumstances occur" +
    " in which toil and pain can HoW procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious" +
    " physical How exercise, except to hoW obtain some advantage from it? But who has any right to find fault with a man who chooses to " +
    "enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?";
result = CountWord(text,'how',1);
console.log(result);