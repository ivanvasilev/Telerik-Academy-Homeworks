var arr = [3, 89, -45, 23, 98, 21345, -12, 0, -443, -87, -90, 29, 165],
    mid,
    searchedNumber = -12;

console.log('The array before sorting it: ' + arr);

sortArray(arr);

console.log('The array after sorting it: ' + arr);

console.log('Number -12 is at index: ' + binarySearch(arr, searchedNumber, 0, arr.length));

function sortArray(arr) {
    for (leftElement = 0, len = arr.length; leftElement < len; leftElement += 1) {
        for (var rightElement = leftElement + 1; rightElement < len; rightElement += 1) {
            if (arr[leftElement] > arr[rightElement]) {
                temp = arr[rightElement];
                arr[rightElement] = arr[leftElement];
                arr[leftElement] = temp;
            }
        }
    }
}

function binarySearch(arr, num, min, max) {
    var mid = min + Math.floor((max - min) / 2);

    if (max < min || num > arr[max]) {
        return -1;
    }

    if (arr[mid] > num) {
        return binarySearch(arr, num, min, mid - 1);
    } else if (arr[mid] < num) {
        return binarySearch(arr, num, mid + 1, max);
    } else {
        return mid;
    }
}