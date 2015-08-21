if (!String.prototype.bind) {
    String.prototype.bind = function (text, options) {
        var option,
            regexContent,
            regexHref,
            regexClass,
            result = this;

        for (option in options) {
            regexContent = new RegExp('(<.*?data-bind-content="' + option + '".*?>)(.*?)(<\\s*/.*?>)', 'g');
            regexHref = new RegExp('(<.*?data-bind-href="' + option + '".*?)>', 'g');
            regexClass = new RegExp('(<.*?data-bind-class="(' + option + ')".*?)>', 'g');

            result = result.replace(regexContent, function (element, openingTag, content, closingTag) {
                return openingTag + options[option] + closingTag;
            })
            .replace(regexHref, function (tag, content) {
                return content + ' href="' + options[option] + '">';
            })
            .replace(regexClass, function (tag, content) {
                return content + ' class="' + options[option] + '">';
            });
        }

        return result;
    }
}

var text = '<div data-bind-content="name"></div>',
    options = { name: 'Steven' },
    text2 = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></а>',
    options2 = { name: 'Elena', link: 'http://telerikacademy.com' };

console.log(text.bind('', options));
console.log(text2.bind('', options2));
