var arr = [3, 2, 3, 4, 2, 2, 4],
    i,
    len,
    result = [],
    lastNumber = 0,
    count = 1,
    maxSequence = 1;

for (i = 1, len = arr.length; i < len; i += 1) {
    if (arr[i] === arr[i - 1] + 1) {
        count += 1;
    }
    else {
        if (count > maxSequence) {
            maxSequence = count;
            lastNumber = arr[i - 1];
        }
        count = 1;
    }
}

for (i = 0; i < maxSequence; i++) {
    result.push(lastNumber - i);
}

result.reverse();

console.log(result);