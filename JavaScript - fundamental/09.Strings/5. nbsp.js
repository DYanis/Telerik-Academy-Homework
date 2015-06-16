function ReplaceWhiteSpace (text){
    for (var i = 0; i < text.length; i++) {
        if(text[i] == ' '){
           text = text.replace(' ','&nbsp')
        }
    }
    console.log(text);
}

ReplaceWhiteSpace('   Yellow Car White Truck');