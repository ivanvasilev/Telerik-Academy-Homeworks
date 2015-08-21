var url = 'http://telerikacademy.com/Courses/Courses/Details/239';

console.log(parseURL(url));

function parseURL(url) {
    var firstSlash = url.indexOf('/'),
        secondSlash = url.indexOf('/', firstSlash + 1),
        thirdSlash = url.indexOf('/', secondSlash + 1),
            result = {};

    result.protocol = url.substring(0, firstSlash - 1);
    result.server = url.substring(secondSlash + 1, thirdSlash);
    result.resource = url.substr(thirdSlash);

    return result;
}