function CorrectBrackets (expresion){
    var openBrackets = 0,
        closeBrackets = 0;

    for (var i = 0; i < expresion.length; i++) {
        if(expresion[i]=== '(' ){

            if(expresion[i+1] !== ')'){
                openBrackets +=1;
            }else {
                console.log('incorrect brackets!');
                return;
            }
        }
        if(expresion[i]===')'){
            if( openBrackets >= closeBrackets+1){
                closeBrackets+=1;
            }else{
                console.log('incorrect brackets!');
                return;
            }
        }
    }
    if(openBrackets !== closeBrackets){
        console.log('incorrect brackets!');
        return;
    }
    console.log('Brackets are correct!');
}

CorrectBrackets('((a+b)/5-d)');
CorrectBrackets(')(a+b))');
