function solve() {
    var library = (function () {
        var books = [];
        var categories = [];

        function listBooks() {
            var result = [];

            books = books.sort(function (a, b) {
                return a.ID - b.ID;
            });

            if (arguments.length === 0) {
                return books;
            }
            else {
                for (prop in arguments[0]) {

                    result = filterBooks(books, prop, arguments[0][prop]);
                }
            }

            function filterBooks(booksArr, key, value) {

                return booksArr.filter(function (book) {
                    return book[key] === value;
                });
            }

            return result;
        }

        function addBook(book) {
            book.ID = books.length + 1;

            if (book.title.length < 2 || book.title.length > 100) {
                throw new Error('The title of the book must be between 2 and 100 characters long!');
            }

            if (book.category.length < 2 || book.category.length > 100) {
                throw new Error('The category of the book must be between 2 and 100 characters long!');
            }

            if (typeof book.author !== 'string' || book.author.trim() === '') {
                throw new Error('Author must be a string with atleast 1 character!');
            }

            if (book.isbn.length !== 10 && book.isbn.length !== 13) {
                throw new Error('ISBN must be either 10 or 13 digits long!');
            }

            for (var i = 0, len = books.length; i < len; i += 1) {
                if (books[i].title === book.title || books[i].isbn === book.isbn) {
                    throw new Error('Books must have unique names and ISBN!');
                }
            }

            if (categories.indexOf(book.category) < 0) {
                addCategory(book.category);
            }

            categories[book.category].books.push(book);
            books.push(book);
            return book;
        }

        function addCategory(name) {
            categories[name] = {
                books: [],
                ID: categories.length + 1
            };
        }

        function listCategories() {
            var result = [];
            Array.prototype.push.apply(result, Object.keys(categories));
            return result;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}