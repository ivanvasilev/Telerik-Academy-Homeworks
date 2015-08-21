var html = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

console.log(extractTextFromHTML(html));

function extractTextFromHTML(html) {
    var result = '',
        i,
        len;
    for (i = 0, len = html.length; i < len; i += 1) {
        if (html[i] === '<') {
            i = html.indexOf('>', i);
        }
        else {
            result += html[i];
        }
    }

    if (!result.length) {
        return 'There is no text in the html!';
    }
    else {
        return result;
    }
}