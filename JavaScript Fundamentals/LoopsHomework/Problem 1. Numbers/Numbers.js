var i,
    infinity = 1 / 0;

for (var i = 1; i < infinity; i += 1) {
    console.log(i);
    if (i === 100) {
        break;
    }
}