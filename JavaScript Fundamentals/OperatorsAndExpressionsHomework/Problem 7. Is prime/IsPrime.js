var prime = 19, notPrime = 50;

console.log(isPrime(prime));
console.log(isPrime(notPrime));

function isPrime(number) {
    if (number < 2) return false;

    for (var divisor = 2; divisor <= Math.sqrt(number) ; divisor++) {
        if (!(number % divisor)) return false;
    }

    return true;
}