function solve() {

    function getSortedAttributesString(attributes) {
        var attributesString = '';
        var keys = [];

        for (var key in attributes) {
            keys.push(key);
        }

        keys.sort();
        var currentKey;

        for (var ind = 0, len = keys.length; ind < len; ind += 1) {
            currentKey = keys[ind];
            attributesString += ' ' + currentKey + '="' + attributes[currentKey] + '"';
        }

        return attributesString;
    }

    var domElement = (function () {
        var domElement = {
            init: function (type) {
                this.type = type;
                this.attributes = {};
                this.content = '';
                this.children = [];
                this.parent;
                return this;
            },
            get type() {
                return this._type;
            },
            set type(value) {
                if (typeof value !== 'string' || value.trim() === '') {
                    throw new Error('Type must be a non empty string!');
                }
                if (!/^[a-z0-9]+$/i.test(value)) {
                    throw new Error('Type must contain only latin letters and digits!');
                }
                this._type = value;
            },
            appendChild: function (child) {
                if (typeof child !== 'string') {
                    child.parent = this;
                }

                this.children.push(child);
                return this;
            },
            addAttribute: function (name, value) {
                if (typeof name !== 'string' || name.trim() === '') {
                    throw new Error('Name must be a non empty string!');
                }
                if (!/^[a-z0-9\-]+$/i.test(name)) {
                    throw new Error('Type must contain only latin letters and digits!');
                }
                this.attributes[name] = value;
                return this;
            },
            removeAttribute: function (attribute) {
                if (!this.attributes[attribute]) {
                    throw new Error('There is no such attribite to delete!');
                }

                delete this.attributes[attribute];
                return this;
            },
            get innerHTML() {
                var innerHtml = '<' + this.type;
                var attributesString = getSortedAttributesString(this.attributes);
                innerHtml += attributesString + '>';

                var child;
                for (var ind = 0, len = this.children.length; ind < len; ind += 1) {
                    child = this.children[ind];

                    if (typeof child === 'string') {
                        innerHtml += child;
                    } else {
                        innerHtml += child.innerHTML;
                    }
                }

                innerHtml += this.content;
                innerHtml += '</' + this.type + '>';

                return innerHtml;
            },
            get content() {
                if (!this.children.length) {
                    return this._content;
                }
                return '';
            },
            set content(value) {
                this._content = value;
            },
            get attributes() {
                return this._attributes;
            },
            set attributes(value) {
                this._attributes = value;
            },
            get children() {
                return this._children;
            },
            set children(value) {
                this._children = value;
            },
            get parent() {
                return this._parent;
            },
            set parent(value) {
                if (!domElement.isPrototypeOf(value)) {
                    throw new Error('Parent must be a dom element!');
                }
                this._parent = value;
            }

        };
        return domElement;
    }());
    return domElement;
}