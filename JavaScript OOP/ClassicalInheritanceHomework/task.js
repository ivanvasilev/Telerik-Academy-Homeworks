function solve() {
    var Person = (function () {
        function Person(firstname, lastname, age) {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        function checkIfAllCharactersAreValid(name) {
            if (!/^[a-z]+$/i.test(name)) {
                throw new Error('First and last name must have only latin letters!');
            }
        }

        Object.defineProperty(Person.prototype, 'firstname', {
            get: function () {
                return this._firstname;
            },
            set: function (value) {
                checkIfAllCharactersAreValid(value);
                if (typeof value !== 'string' || value.length < 3 || value.length > 20) {
                    throw new Error('First name must be a string between 3 and 20 characters long!');
                }
                this._firstname = value;
                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'lastname', {
            get: function () {
                return this._lastname;
            },
            set: function (value) {
                checkIfAllCharactersAreValid(value);
                if (typeof value !== 'string' || value.length < 3 || value.length > 20) {
                    throw new Error('Last name must be a string between 3 and 20 characters long!');
                }
                this._lastname = value;
                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'age', {
            get: function () {
                return this._age;
            },
            set: function (value) {
                value = parseInt(value);
                if (typeof value !== 'number' || value < 0 || value > 150) {
                    throw new Error('Age must be a number between 0 and 150!');
                }
                this._age = value;
                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function () {
                return this.firstname + ' ' + this.lastname;
            },
            set: function (value) {
                var result = value.split(' ');
                if (result.length !== 2) {
                    throw new Error('Invalid fullname!')
                }
                this.firstname = result[0];
                this.lastname = result[1];
            }
        });

        Person.prototype.introduce = function () {
            var result = 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
            return result;
        }

        return Person;
    }());
    return Person;
}