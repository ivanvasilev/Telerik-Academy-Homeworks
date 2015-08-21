var array = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    count = 1,
    number,
    maxSequence = 1,
    i,
    len,
    result = [];

for (i = 1, len = array.length; i < len; i += 1) {
    if (array[i] === array[i - 1]) {
        count += 1;
    }
    else {
        if (count > maxSequence) {
            maxSequence = count;
            number = array[i - 1];
        }
        count = 1;
    }
}


for (i = 0; i < maxSequence; i++) {
    result.push(number);
}

console.log(result)