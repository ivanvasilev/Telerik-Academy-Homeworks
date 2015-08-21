function solve() {
    return function (selector) {
        var element = $(selector),
            buttonElements,
            contentElements,
            nextElement,
                currVal;

        if (element.length === 0) {
            throw new Error('Nothing is selected!');
        }

        if (typeof selector !== 'string') {
            throw new Error('Selector must be a jQuery object or a string!');
        }

        buttonElements = $('.button').text('hide');
        contentElements = $('.content');

        element.on('click', '.button', function () {
            var $this = $(this);
            nextElement = $this.next();

            while (!nextElement.hasClass('button')) {
                if (nextElement.hasClass('content')) {
                    break;
                }
                nextElement = nextElement.next();
            }

            currVal = nextElement.css('display');

            if (nextElement.hasClass('content') && nextElement.css('display') === 'none') {
                $this.text('hide');
                nextElement.css('display', '');
            }
            else if (nextElement.hasClass('content') && nextElement.css('display') === currVal) {
                $this.text('show');
                nextElement.css('display', 'none');
            }
        })
    };
}