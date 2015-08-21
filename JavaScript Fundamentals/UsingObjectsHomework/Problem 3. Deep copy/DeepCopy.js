var arrOfObjects = [{ name: 'Jimmy', age: 12 }, { team: 'Botev', year: 1912 }, 567, null, undefined],
    i,
    len,
    clone = {};

for (i = 0, len = arrOfObjects.length; i < len; i += 1) {
    console.log(makeACopyOfAnObject(arrOfObjects[i]));
}

clone = makeACopyOfAnObject(arrOfObjects[0]);
clone.name = 'Billy';
console.log(arrOfObjects[0].name)
console.log(clone.name);
console.log(arrOfObjects[0].name === clone.name)

function makeACopyOfAnObject(obj) {
    var clonedObj = {},
        prop;

    if (typeof obj !== 'object') {
        return obj;
    }

    for (prop in obj) {
        clonedObj[prop] = makeACopyOfAnObject(obj[prop]);
    }

    return clonedObj;
}