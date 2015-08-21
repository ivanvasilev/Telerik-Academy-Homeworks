function(){
    return function sum(array) {
        if (!Array.isArray(array)) {
            throw new Error('Input type must be Array!');
        }

        if (array.length === 0) {
            return null;
        }

        return array.reduce(function (sum, number) {
            number = +number;
            if (isNaN(number)) {
                throw new Error('Not all elemnts in the array are numbers!');
            }

            return sum + number;
        }, 0);
    };
};