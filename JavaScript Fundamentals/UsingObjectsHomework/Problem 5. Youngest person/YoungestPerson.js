var people = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'Kiro', lastname: 'Skalata', age: 40 },
    { firstname: 'Kolyo', lastname: 'Mamata', age: 50 },
    { firstname: 'Joey', lastname: 'Battle', age: 25 },
];

console.log('The youngest person in the array is: ' + findYoungestPerson(people));

function findYoungestPerson(arr) {
    var i,
        len,
        result = '',
        index = 0,
        youngest = 150;

    for (i = 0, len = arr.length; i < len; i += 1) {
        if (arr[i].age < youngest) {
            youngest = arr[i].age;
            index = i;
        }
    }

    result = arr[index].firstname + ' ' + arr[index].lastname;
    return result;
}