function solve() {
    return function (selector) {
        var contentElements,
            buttonElements,
            nextElement,
            i,
            len;

        if (!(selector instanceof HTMLElement)) {
            if (typeof selector === 'string') {
                selector = document.getElementById(selector);
                if (selector === null) {
                    throw new Error('There is no sych element with such ID!');
                }
            }
            else {
                throw new Error('Element must be a DOM element or a string!');
            }
        }

        contentElements = selector.getElementsByClassName('content');
        buttonElements = selector.getElementsByClassName('button');
        len = buttonElements.length;

        for (i = 0; i < len; i += 1) {
            buttonElements[i].textContent = 'hide';
            buttonElements[i].addEventListener('click', function () {
                nextElement = this.nextElementSibling;

                while (nextElement.className !== 'button') {
                    if (nextElement.className === 'content') {
                        break;
                    }
                    nextElement = nextElement.nextElementSibling;
                }

                if (nextElement.className === 'content' && nextElement.style.display === '') {
                    this.textContent = 'show';
                    nextElement.style.display = 'none';
                }
                else if (nextElement.className === 'content' && nextElement.style.display === 'none') {
                    this.textContent = 'hide';
                    nextElement.style.display = '';
                }
            });
        }
    }
};