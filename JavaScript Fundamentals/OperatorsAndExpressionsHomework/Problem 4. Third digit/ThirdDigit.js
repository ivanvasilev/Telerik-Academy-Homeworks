var array = [5, 701, 1732, 9703, 877, 777877, 9999799];

for (var i = 0; i < array.length; i++) {
    if (array[i].length < 3) {console.log(array[i] + ' - false')}
    else 
    {
        var temp = Math.floor(array[i] / 100);
        if (temp % 10 === 7) {console.log(array[i] + ' - true')}
        else { console.log(array[i] + ' - false') }
    }
}