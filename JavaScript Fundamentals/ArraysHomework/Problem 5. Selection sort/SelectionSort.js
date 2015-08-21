var arr = [3, 89, -45, 23, 98, 21345, -12, 0, -443, -87, -90, 29, 165],
    leftElement,
    rightElement,
    i,
    len,
    temp;

for (leftElement = 0, len = arr.length; leftElement < len; leftElement += 1) {
    for (var rightElement = leftElement + 1; rightElement < len; rightElement += 1) {
        if (arr[leftElement] > arr[rightElement]) {
            temp = arr[rightElement];
            arr[rightElement] = arr[leftElement];
            arr[leftElement] = temp;
        }
    }
}

console.log(arr.join(', '));