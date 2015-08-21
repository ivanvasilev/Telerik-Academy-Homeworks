var numbers = [2, 7, -1, -44, 65, 0, 90, 76, -89, 105, 8],
    i, 
    maxValue = Math.max(),
    minValue = Math.min();

console.log('The smallest number is: ' + getMinNumber(numbers));
console.log('The biggest number is: ' + getMaxNumber(numbers));
console.log('Finding max in min numbers in a sequence, using only one loop: ');
console.log(getMinAndMaxNumbers(numbers));

function getMinNumber(numbers) {
    for (i = 0; i < numbers.length; i += 1) {
        if (numbers[i] < minValue) {
            minValue = numbers[i];
        }
    }
    return minValue;
}

function getMaxNumber(numbers) {
    for (i = 0; i < numbers.length; i += 1) {
        if (numbers[i] > maxValue) {
            maxValue = numbers[i];
        }
    }
    return maxValue;
}

// Another solution with one loop

function getMinAndMaxNumbers(numbers) {
    for (i = 0; i < numbers.length; i += 1) {
        if (numbers[i] > maxValue) {
            maxValue = numbers[i];
        }
        if (numbers[i] < minValue) {
            minValue = numbers[i];
        }
        var result = 'The smallest number is: ' + minValue + '\n' + 'The biggest number is: ' + maxValue
        return result;
    }
}