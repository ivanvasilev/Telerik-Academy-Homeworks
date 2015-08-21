//Problem 1. Make person

//Write a function for creating persons.
//Each person must have firstname, lastname, age and gender (true is female, false is male)
//    Generate an array with ten person with different names, ages and genders

if (!Array.prototype.fill) {
    Array.prototype.fill = function (value) {
        var i,
            len;
        for (i = 0, len = this.length ; i < len; i += 1) {
            this[i] = value;
        }
        return this;
    }
}

var arr = [],
    number = 10;
people = [];

arr.length = number;

people = arr.fill(1).map(function (_, i) {
    return {
        firstName: 'first' + i,
        lastName: 'last' + i,
        age: 15 + i,
        isMale: !!(i % 2)
    };
}
        );

console.log('People: ');
console.log(people);

//Problem 2. People of age

//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//    Use only array methods and no regular loops (for, while)

var areAllPeopleOver18;

areAllPeopleOver18 = people.every(function (person) {
    return person.age >= 18;
})

console.log('Are all people over 18: ' + areAllPeopleOver18);

//Problem 3. Underage people

//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)

var underagedPeople;

console.log('People under 18: ');
underagedPeople = people.filter(function (person) {
    return person.age < 18;
}).forEach(function (person) {
    console.log(person);
});

//Problem 4. Average age of females

//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)

var females = [],
    sumOfAges = 0,
    averageAgeOfFemales = 0;

females = people.filter(function (person) {
    return !person.isMale;
});

sumOfAges = females.reduce(function (r, person) {
    return r + person.age;
}, 0)

averageAgeOfFemales = +sumOfAges / females.length;

console.log('Average age of all females: ' + averageAgeOfFemales);

//Problem 5. Youngest person

//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//    Use Array#find

var youngestMale;

if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i,
            len;
        for (i = 0, len = this.length ; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
        return undefined;
    }
}

youngestMale = people.sort(function (a, b) {
    return a.age - b.age;
}).find(function (person) {
    return person.isMale;
});

console.log('Youngest male: ' + youngestMale.firstName + ' ' + youngestMale.lastName);

//Problem 6. Group people

//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)

var groupedPeopleByFirstLetterOfFirstName;

people[0].firstName = 'gosho';
people[3].firstName = 'grigor';
people[6].firstName = 'asen';
people[8].firstName = 'asparuh';
people[9].firstName = 'pesho';

groupedPeopleByFirstLetterOfFirstName = people.reduce(function (g, person) {
    var letter = person.firstName[0];

    if (g[letter]) {
        g[letter].push(person);
    }
    else {
        g[letter] = [person];
    }

    return g;
}, {})

console.log('Groups of people with the same first letter of the first name: ');
console.log(groupedPeopleByFirstLetterOfFirstName);