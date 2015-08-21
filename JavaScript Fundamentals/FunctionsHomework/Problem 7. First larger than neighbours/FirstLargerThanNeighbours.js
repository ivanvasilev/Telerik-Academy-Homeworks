var arr = [4, 1, 3, 5, 5, 4, 1, 3, 4, 5, 6, 7, 8, 8, 9];

console.log(checkIfArrayHasANumberBiggerThanItsNeighbours(arr));

function checkIfArrayHasANumberBiggerThanItsNeighbours(arr) {
    var i,
        len;
    for (i = 1, len = arr.length - 1; i < len; i += 1) {
        if(arr[i] > arr[i-1] && arr[i] > arr[i+1]){
            return i;
        }
    }
    return -1;
}