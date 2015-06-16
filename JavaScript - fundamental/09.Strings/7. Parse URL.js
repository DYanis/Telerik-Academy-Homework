function parseURL (arg){
    var subStr = '',
        result = {},
        breaker = true;

    for (var i = 0; i < arg.length; i++) {
        subStr+=arg[i];
        if(arg[i+1]==='/'&&arg[i+2]==='/'){
            result.protocol = subStr;
            subStr = '';
            i += 2;
            continue;
        }
        if(arg[i+1]==='/' && breaker){
            result.server= subStr;
            subStr = '';
            i+=1;
            breaker = false;
            continue;
        }
    }
    result.resource = subStr;
    return result;
}

console.log(parseURL('http://telerikacademy.com/Courses/Courses/Details/239'));