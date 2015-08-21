function solve() {
    function validateTitles(title) {
        if (title.length === 0) {
            throw new Error('Titles can not be empty strings!');
        }
        if (title[0] === ' ' || title[title.length - 1] === ' ') {
            throw new Error('Titles can not start and end white white space!');
        }
        if (/\s\s/.test(title)) {
            throw new Error('Title can not have multiple white spaces!');
        }
    }

    function checkArrayOfPresentationsForValidTitles(presentations) {
        var i,
            len = presentations.length;

        if (len === 0) {
            throw new Error('The array of presentations must not be empty!');
        }

        for (i = 0; i < len; i += 1) {
            validateTitles(presentations[i]);
        }
    }

    var Course = {
        init: function (title, presentations) {
            this.title = title;
            this.presentations = presentations;
            this.students = [];
            return this;
        },
        addStudent: function (name) {
            var i,
                student = {};

            name = name.split(' ');
            if (name.length !== 2) {
                throw new Error('Invalid student name!');
            }

            for (i = 0; i < 2; i += 1) {
                if (name[i][0] !== name[i][0].toUpperCase()) {
                    throw new Error('The first letter of each name must be a capital letter!');
                }
                if (name[i].substr(1) !== name[i].substr(1).toLowerCase()) {
                    throw new Error('Every letter wothout the first one must be in lower case!');
                }
            }
            student.firstname = name[0];
            student.lastname = name[1];
            student.id = this.students.length + 1;

            this.students.push(student);

            return student.id;
        },
        getAllStudents: function () {
            return this.students.slice();
        },
        submitHomework: function (studentID, homeworkID) {
            studentID = +studentID;
            homeworkID = +homeworkID;
            if (studentID < 1 || studentID > this.students.length) {
                throw new Error('Invalid student ID!');
            }
            if (homeworkID < 1 || homeworkID > this.presentations.length) {
                throw new Error('Invalid homework ID!');
            }
        },
        pushExamResults: function (results) {
        },
        getTopStudents: function () {
        },
        get presentations() {
            return this._presentations;
        },
        set presentations(value) {
            checkArrayOfPresentationsForValidTitles(value);
            this._presentations = value;
        },
        get title() {
            return this._title;
        },
        set title(value) {
            validateTitles(value);
            this._title = value;
        }

    };

    return Course;
}