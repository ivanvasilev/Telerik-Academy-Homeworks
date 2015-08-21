var arrOfObjects = [{ name: 'Jimmy', age: 12 }, { team: 'Botev', year: 1912 }, 567],
    i,
    len,
    clone = {};

for (i = 0, len = arrOfObjects.length; i < len; i += 1) {
    console.log(hasProperty(arrOfObjects[i], 'age'));
}

arrOfObjects[1].age = 103;
console.log('Has the property "age": ' + hasProperty(arrOfObjects[1], 'age'));

function hasProperty(obj, prop) {
    return obj.hasOwnProperty(prop);
}