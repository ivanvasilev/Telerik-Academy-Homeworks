var arr = [512, 1024, 12309],
    i,
    len;

for (i = 0, len = arr.length; i < len; i += 1) {
    console.log(lastDigitAsWord(arr[i]))
}

function lastDigitAsWord(number) {
    switch (number % 10) {
        case 0: return 'zero';
        case 1: return 'one';
        case 2: return 'two';
        case 3: return 'three';
        case 4: return 'four';
        case 5: return 'five';
        case 6: return 'six';
        case 7: return 'seven';
        case 8: return 'eight';
        case 9: return 'nine';
    }
}