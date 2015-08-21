var arr = [4, 7, 3, 5, 5, 4, 1, 8, 4, 0, 8, 7, 6, 9, 1],
    searchedIndexes = [-1, 0, 7, 9, 14, 15],
    i,
    leng;

for (i = 0, leng = searchedIndexes.length; i < leng; i++) {
    console.log('arr[' + searchedIndexes[i] + '] - ' + checkIfNumberIsBiggerThanItsNeighbours(arr, searchedIndexes[i]));
}

function checkIfNumberIsBiggerThanItsNeighbours(arr, index) {
    var lastIndex = arr.length - 1;
    if (!index || index === lastIndex) {
        return 'The number at this index has only one neighbour!'
    }
    else if (index < 0 || index > lastIndex) {
        return 'There is no such index in this array!'
    }
    else {
        if (arr[index] > arr[index-1] && arr[index] > arr[index+1]) {
            return 'The number at this index is bigger than its neighbours!'
        }
        else {
            return 'The number at this index is not bigger than its neighbours!';
        }
    }
}