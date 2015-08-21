// Problem 1. JavaScript literals
    // Assign all the possible JavaScript literals to different variables.

var int = 10,
    string = 'pesho',
    arr = [10, 11, 12],
    obj = { name: 'pesho', age: 22 },
    bool = true,
    float = 10.13,
    func = function () { return };

// Problem 3. Typeof variables
    //Try typeof on all variables you created.

console.log('Problems 1 and 3:');
var array = [int, string, arr, obj, bool, float, func];
for (var i = 0; i < array.length; i++) {
    console.log('Value: ' + array[i] + ' - ' + 'Type: ' + typeof array[i]);
}

// Problem 2. Quoted text
    // Create a string variable with quoted text in it.
    // For example: `'How you doin'?', Joey said'.

var quotedString = "'How you doin'?', Joey said'";
console.log('Problem 2:')
console.log(quotedString)

// Problem 4. Typeof null
    // Create null, undefined variables and try typeof on them.

console.log('Problem 4:')
var undefinedValue = undefined,
    nullValue = null;

var newArray = [undefinedValue, nullValue];
for (var i = 0; i < newArray.length; i++) {
    console.log('Value: ' + newArray[i] + ' - ' + 'Type: ' + typeof newArray[i]);
}