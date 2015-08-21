var a = 7,
    b = 13,
    temp;

console.log('Before change: ' + 'a = ' + a + ' b = ' + b);

if (a < b) {
    temp = a;
    a = b;
    b = temp;
}
console.log('After change: ' + 'a = ' + a + ' b = ' + b);