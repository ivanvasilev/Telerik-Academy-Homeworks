var array = [3, 2, -2, -1, 0];

console.log("n   Odd?")
for (var i = 0; i < array.length; i++) {
    if (array[i] === 0) {console.log(array[i] + ' - false');}
    else if (array[i] % 2 === 0) { console.log(array[i] + ' - false'); }
    else { console.log(array[i] + ' - true'); };
}