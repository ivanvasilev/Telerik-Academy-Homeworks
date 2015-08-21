var arr = ['256', '123.45', '-876', '7331'],
    i,
    len;

for (i = 0, len = arr.length; i < len; i += 1) {
    console.log(reverseNumber(arr[i]));
}

function reverseNumber(number) {
    var j,
        result = '';
    for (j = number.length - 1; j >= 0; j -= 1) {
        if (number[j] === '-') {
            result = '-' + result;
        }
        else {
            result += number[j];
        }
    }
    return result;
}