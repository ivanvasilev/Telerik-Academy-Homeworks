function(){
    return function findPrimes(start, end) {
        if (typeof start === 'undefined' || typeof end === undefined) {
            throw new Error('You must enter both start and end numbers!');
        }
        start = +start;
        end = +end;

        if (isNaN(start) || isNaN(end)) {
            throw new Error('Both parameters must be numbers!');
        }

        var number,
            devisor,
            maxDevisor,
            result = [],
            isPrime;

        for (number = start; number <= end; number += 1) {
            maxDevisor = Math.sqrt(number);
            isPrime = true;
            for (devisor = 2; devisor <= maxDevisor; devisor += 1) {
                if (!(number % devisor)) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime && number > 1) {
                result.push(number);
            }
        }

        return result;
    };
}