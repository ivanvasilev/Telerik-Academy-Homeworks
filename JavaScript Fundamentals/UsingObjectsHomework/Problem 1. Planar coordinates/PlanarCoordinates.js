var firstX = 4,
    secondX = 2,
    thirdX = 1,
    firstY = 1,
    secondY = 3,
    thirdY = 6,
    pointOne,
    pointTwo,
    pointThree,
    lineOne,
    lineTwo,
    lineThree,
    result;

pointOne = createPoint(firstX, firstY);
pointTwo = createPoint(secondX, secondY);
pointThree = createPoint(thirdX, thirdY);

console.log(pointOne);
console.log(pointTwo);
console.log(pointThree);

lineOne = createLine(pointOne, pointTwo);
lineTwo = createLine(pointOne, pointThree);
lineThree = createLine(pointTwo, pointThree);

console.log(lineOne);
console.log(lineTwo);
console.log(lineThree);

result = checkForAnExistingTriangle(lineOne, lineTwo, lineThree);

console.log('Is there an existing triangle with these sides: ' + result);

function createPoint(x, y) {
    return {
        'x': x,
        'y': y
    };
}

function createLine(firstPoint, secondPoint) {
    return {
        'p1': firstPoint,
        'p2': secondPoint,
        'length': calculateDistance(firstPoint, secondPoint)
    };
}

function calculateDistance(firstPoint, secondPoint) {
    return Math.sqrt((firstPoint.x - secondPoint.x) * (firstPoint.x - secondPoint.x) +
        (firstPoint.y - secondPoint.y) * (firstPoint.y - secondPoint.y));
}

function checkForAnExistingTriangle(firstLine, secondLine, thirdLine) {
    if ((firstLine.length + secondLine.length > thirdLine.length) &&
        (firstLine.length + thirdLine.length > secondLine.length) &&
        (secondLine.length + thirdLine.length > firstLine.length)) {
        return true;
    }
    return false;
}