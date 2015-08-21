var text = ' We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';

console.log(replaceWhiteSpace(text));

function replaceWhiteSpace(text) {
    return (text.split(/\s/g).join('&nbsp;'));
}