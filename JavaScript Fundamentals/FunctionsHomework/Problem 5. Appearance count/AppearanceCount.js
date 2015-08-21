var arr = [1, 2, 3, 4, 5, 7, 1, 2, 5, 1, 7, 3, 9, 4, 2, 4, 6, 7, 8, 1, 3, 5, 1, 1, 7, 1, 8, 4, 2, 6, 1, 6, 1],
    numberToFind = 1,
    expectedResult = 9;

console.log(arr);
console.log('Number 1 is contained ' + occuruncesOfANumber(arr, numberToFind) + ' times in the given array.');
console.log('Does the function work as expected: ' + checkFunction());

function occuruncesOfANumber(array, number) {
    var i,
        len,
        counter = 0;
    for (i = 0, len = array.length; i < len; i += 1) {
        if (arr[i] === numberToFind) {
            counter += 1;
        }
    }
    return counter;
}

function checkFunction() {
    return occuruncesOfANumber(arr, numberToFind) === expectedResult;
}
