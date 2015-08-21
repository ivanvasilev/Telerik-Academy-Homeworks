var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    count = 0,
    maxCount = 0,
    currentNumber,
    mostFrequentNumber,
    i,
    j,
    len;

for (i = 0, len = arr.length; i < len; i += 1) {
    currentNumber = arr[i];
    for (j = 0; j < len; j += 1) {
        if (arr[j] === currentNumber) {
            count += 1;
            if (count > maxCount) {
                maxCount = count;
                mostFrequentNumber = currentNumber;
            }
        }
    }
    count = 0;
}

console.log(mostFrequentNumber + ' - ' + maxCount + ' times');