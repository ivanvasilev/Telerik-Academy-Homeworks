var gosho = createPerson('Gosho', 'Petrov', 32),
    bay = createPerson('Bay', 'Ivan', 81),
    kiro = createPerson('Kiro', 'Skalata', 40),
    kolyo = createPerson('Kolyo', 'Mamata', 50),
    bay2 = createPerson('Bay', 'Mangal', 25),
    joey = createPerson('Joey', 'Battle', 25),
    kiro2 = createPerson('Kiro', 'Petrov', 81),
    joey2 = createPerson('Joey', 'Ivan', 50),
    bay3 = createPerson('Bay', 'Battle', 32),
    people = [gosho, bay, kiro, kolyo, bay2, joey, kiro2, joey2, bay3],
    groupedByAge,
    groupByFirstname,
    groupByLastname;

    groupedByAge = group(people, 'age');
    groupByFirstname = group(people, 'firstname');
    groupByLastname = group(people, 'lastname');
    
    console.log(groupedByAge);
    console.log(groupByFirstname);
    console.log(groupByLastname);

function createPerson(firstname, lastname, age) {
    return {
        firstname: firstname,
        lastname: lastname,
        age: age
    };
}

function group(arr, prop) {
    var person,
        result = {};

    for (person in arr) {
        var groupProperty = arr[person][prop];

        if (!result.hasOwnProperty(groupProperty)) {
            result[groupProperty] = [];
        }

        result[groupProperty].push(arr[person]);
    }
    return result;
}