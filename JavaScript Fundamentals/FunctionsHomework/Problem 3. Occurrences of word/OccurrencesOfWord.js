var text = 'This is the text in which I am going to search for a certain word. The word that I am searching for is Word.',
    word = 'word',
    counter = 0;

console.log(searchForWord(text, word));

function searchForWord(text, word) {
    var index = 0,
        counter = 0;

    while (index >= 0) {
        counter += 1;
        index = text.indexOf(word, index + 1)
    }

    if (counter > 0) {
        return counter;
    }
    else {
        return -1;
    }
}