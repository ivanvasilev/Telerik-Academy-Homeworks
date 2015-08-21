if (!String.prototype.format) {
    String.prototype.format = function (placeholders) {
        var placeholder,
            regex,
            result = this;

        for (placeholder in placeholders) {
            regex = new RegExp('#{' + placeholder + '}', 'g');
            result = result.replace(regex, placeholders[placeholder]);
        }

        return result;
    }
}

var placeholders = { name: 'John' },
    text = 'Hello, there! Are you #{name}?',
    placeholders2 = { name: 'John', age: 13 },
    text2 = 'My name is #{name} and I am #{age}-years-old';

console.log(text.format(placeholders));
console.log(text2.format(placeholders2));