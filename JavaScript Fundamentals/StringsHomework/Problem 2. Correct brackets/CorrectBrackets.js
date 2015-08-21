var expressions = ['((a+b)/5-d)', ')(a+b))', ')a+b('],
    i,
    len;

for (i = 0, len = expressions.length; i < len; i += 1) {
    console.log(checkForValidBrackets(expressions[i]));
}

function checkForValidBrackets(exp) {
    var i,
        len,
        count = 0;

    if (exp.indexOf('(') > exp.indexOf(')')) {
        return 'Incorrect!';
    }
    else {
        for (i = 0, len = exp.length; i < len; i += 1) {
            if (exp[i] === '(') {
                count += 1;
            }
            if (exp[i] === ')') {
                count -= 1;
            }
        }

        if (!count) {
            return 'Correct!'
        }
        else {
            return 'Incorrect!'
        }
    }
}