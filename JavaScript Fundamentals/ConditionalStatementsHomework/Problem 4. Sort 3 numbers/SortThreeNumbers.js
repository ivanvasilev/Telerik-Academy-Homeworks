var a = 2,
    b = -6,
    c = 5;

if (a > b) {
    if (b > c) {
        console.log(a + ' ' + b + ' ' + c);
    }
    else {
        if (a > c) {
            console.log(a + ' ' + c + ' ' + b);
        }
        else {
            console.log(c + ' ' + a + ' ' + b);
        }
    }
}
else {
    if (a > c) {
        console.log(b + ' ' + a + ' ' + c);
    }
    else {
        if (b > c) {
            console.log(b + ' ' + c + ' ' + a);
        }
        else {
            console.log(c + ' ' + b + ' ' + a);
        }
    }
}