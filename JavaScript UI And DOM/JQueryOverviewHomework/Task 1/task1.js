function solve() {
    return function (selector, count) {
        var element = $(selector),
            ul = $('<ul />').addClass('items-list'),
            li;

        if (typeof selector !== 'string') {
            throw new Error('Selector must be a  string!');
        }

        if (isNaN(count) || count < 1) {
            throw new Error('Count must be a number!');
        }

        if (typeof count === 'string') {
            count = +count;
        }

        if (element.length > 0) {
            for (var i = 0; i < count; i++) {
                li = $('<li>').addClass('list-item').text('List item #' + i);
                ul.append(li);
            }
        }

        element.append(ul);
    };
}