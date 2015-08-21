var text = 'I am going to write some words: otto, jimmy, ABBa, west, east, bob, lol, scoop, Lamal.'

console.log(findPalindromes(text));

function findPalindromes(text) {
    var input = text.split(/[ ,.:]/g).filter(function (word) { return !!word; }),
        i,
        len,
        result = [];
    for (i = 0, len = input.length; i < len; i += 1) {
        if (input[i].length > 1 && input[i].toLowerCase() === reverseWord(input[i]).toLowerCase()) {
            result.push(input[i]);
        }
    }
    return result;
}

function reverseWord(word) {
    return word.split('').reverse().join('');
}
