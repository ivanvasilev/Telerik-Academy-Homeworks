if (!String.prototype.reverse) {
    String.prototype.reverse = function () {
        var i,
            len = this.length,
            result = '';
        for (i = len - 1; i >= 0; i -= 1) {
            result += this[i];
        }
        return result;
    }
}

var someString = 'Some string',
    reversed;

reversed = someString.reverse();

console.log(reversed);

