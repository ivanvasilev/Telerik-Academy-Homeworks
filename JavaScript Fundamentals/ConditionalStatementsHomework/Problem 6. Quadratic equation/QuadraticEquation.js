var a = 1,
    b = -6,
    c = 5,
    d = (b * b) - (4 * a * c),
    firstRoot = (-b + Math.sqrt(d)) / (2 * a),
    secondRoot = (-b - Math.sqrt(d)) / (2 * a),
    oneRealRoot = -b / (2 * a);

if (d > 0) {
    console.log('The equation has two real roots: x1 = ' + firstRoot + ', x2 = ' + secondRoot)
}
else if (d === 0) {
    console.log('The equation has one real root: x = ' + oneRealRoot)
}
else {
    console.log('The equation has no real roots!')
}