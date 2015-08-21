var first = ['a', 'b', 'c', 'd'],
    second = ['a', 'b', 'c', 'd'],
    third = ['a', 'b', 'c', 'e'],
    i,
    len,
    temp = true;

for (i = 0, len = first.length; i < len; i += 1) {
    if (first[i] !== second[i]) {
        temp = false;
        break;
    }
}

console.log(temp);

temp = true;

for (i = 0, len = first.length; i < len; i += 1) {
    if (first[i] !== third[i]) {
        temp = false;
        break;
    }
}

console.log(temp);