var array = [3, 0, 5, 7, 35, 140];

for (var i = 0; i < array.length; i++) {
    if (array[i] % 5 === 0 && array[i] % 7 === 0) { console.log(array[i] + ' - true') }
    else { console.log(array[i] + ' - false') }
}