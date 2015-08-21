if (!Array.prototype.remove) {
    Array.prototype.remove = function (item) {
        var i,
            len;
        for (i = 0, len = this.length; i < len; i += 1) {
            if (this[i] === item) {
                this.splice(i, 1);
                i -= 1;
                len -= 1;
            }
        }
    }
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
console.log(arr);
arr.remove(1);
console.log(arr);