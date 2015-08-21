var text = 'The text is as follows: We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.',
    word = 'in';

console.log(checkCountOfSubstringInText(text, word));

function checkCountOfSubstringInText(text, word) {
    var count = 0,
        index = 0;

    text = text.toLowerCase();
    word = word.toLocaleLowerCase();

    while (index >= 0) {
        count += 1;
        index = text.indexOf(word, index + 1);
    }

    count -= 1;

    if (!count) {
        return -1;
    }
    else {
        return count;
    }
}