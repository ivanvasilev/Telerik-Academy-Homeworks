var array = [5, 8, 0, 15, 5343, 62241];

for (var i = 0; i < array.length; i++) {
    console.log(array[i] + ' - ' + pad((array[i] >>> 0).toString(2), 16) + ' - ' + (array[i] >> 3 & 1))
}

function pad(n, width, z) {
    z = z || '0';
    n = n + '';
    return n.length >= width ? n : new Array(width - n.length + 1).join(z) + n;
}