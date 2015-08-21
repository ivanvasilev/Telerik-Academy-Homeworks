var arr = [],
    count = 20,
    i,
    len;

arr[count - 1] = undefined;

for (i = 0, len = arr.length; i < len; i += 1) {
    arr[i] = i * 5;
    console.log('arr[' + i + '] - ' + arr[i])
}