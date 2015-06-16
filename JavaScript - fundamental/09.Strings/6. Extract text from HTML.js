function ExtractText (html){
    var open = 0,
        close = 0,
        result = '';

    for (var i = 0; i < html.length; i++) {

        if(html[i]==='<'){
            open+=1;
        }else if(html[i]==='>'){
            close+=1;
            continue;
        }
        if(open === close){
            result+=html[i];
        }

    }
    console.log(result);

}
str = '\<html>\<head>\<title>Sample site\</title>\</head>\<body>\<div>text\<div>more text</div>and more...\</div>in body\</body>\</html>';
ExtractText(str);