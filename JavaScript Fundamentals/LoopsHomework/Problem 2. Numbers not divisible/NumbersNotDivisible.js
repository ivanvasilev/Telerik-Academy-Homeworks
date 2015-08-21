var i;

for (i = 1; i <= 100; i += 1) {
    if (!(i % 3 === 0 && i % 7 === 0)) {
        console.log(i)
    }
}

// Another solution

console.log('Dividing directly by 21: ');
for (i = 1; i <= 100; i += 1) {
    if (i % 21 !== 0) {
        console.log(i);
    }
}