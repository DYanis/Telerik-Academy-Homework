function createPeople(fName,lName,age){
    var people = {
        firstName : fName,
        lastName : lName,
        age : age
    };
    return people;
}

function group(people,groupParam) {
    //fName

    var assocArr = {};

    for (var i = 0; i < people.length; i++) {
        var namE = people[i].firstName;
        if (!assocArr.namE) {
            assocArr.namE = [];
            assocArr.namE.push(people[i]);
        }else{
            assocArr.namE.push(people[i])
        }

    }
}


var toncho = createPeople('toncho','minkov',24),
    ivan = createPeople('ivan','sotirov',14),
joro = createPeople('joro','minkov',18),
toncho2 = createPeople('toncho','kirov',52),
kosta = createPeople('kosta','minkov',124),
nikol = createPeople('nikol','petrova',29);
group([toncho,ivan,joro,toncho2,kosta,nikol],'fname');

/*var toncho = createPeople('toncho','minkov',24);
console.log(toncho);

if(!toncho.firstName){
    console.log('in!');
}
console.log(!!toncho.firstName);*/