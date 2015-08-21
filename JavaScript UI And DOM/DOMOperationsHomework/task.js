function () {

    return function (element, contents) {
        var element,
            documentFragment = document.createDocumentFragment(),
            len,
            i,
            div;

        if (typeof element === 'undefined' || typeof contents === 'undefined') {
            throw new Error('One or more parameters is missing!');
        }

        if (!(element instanceof HTMLElement)) {
            if (typeof element === 'string') {
                element = document.getElementById(element);
                if (element === null) {
                    throw new Error('There is no sych element with such ID!');
                }
            }
            else {
                throw new Error('Element must be a DOM element or a string!');
            }
        }

        if (!Array.isArray(contents)) {
            throw new Error('Contents must be an array!');
        }

        len = contents.length;

        for (i = 0; i < len; i += 1) {
            if (!(typeof contents[i] === 'string' || typeof contents[i] === 'number')) {
                throw new Error('Content elements must be of type number or string!');
            }
        }

        element.innerHTML = '';
        
        
        for (i = 0; i < len; i += 1) {
            div = document.createElement('div');
            div.textContent = contents[i];
            documentFragment.appendChild(div);
        }
        element.appendChild(documentFragment);
    };
};