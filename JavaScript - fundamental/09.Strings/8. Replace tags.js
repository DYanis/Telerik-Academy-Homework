function ReplaceTags (text){
    var start= 0,
        result = '';
    text = text.replace(/<a href="/g, '[URL=');
    for (var i = 0; i < text.length; i++) {
        if (text[i - 1] === '"' && text[i] === '>') {
            result += text.substring(start, i - 1) + ']';
            start = i + 1;
        }
    }
    result += text.substring(start,text.length);
    console.log(result);
}

var str ="\<p\>Please visit \<a href=\"http://academy.telerik.com\"\>our site\</a> to choose a training course. Also visit \<a href=\"www.devbg.org\">our forum\</a> to discuss the courses.\</p>";
ReplaceTags(str);