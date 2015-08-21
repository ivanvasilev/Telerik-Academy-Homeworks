function solve() {

    function isStringValid(someValue) {
        return typeof someValue === 'string' &&
                      someValue.length >= 3 &&
                      someValue.length <= 25;
    }

    validator = {
        validateIfUndefined: function (val, name) {
            name = name || 'Value';
            if (val === undefined) {
                throw new Error(name + ' cannot be undefined');
            }
        },
        validateIfObject: function (val, name) {
            name = name || 'Value';
            if (typeof val !== 'object') {
                throw new Error(name + ' must be an object');
            }
        },
        validateIfNumber: function (val, name) {
            name = name || 'Value';
            if (typeof val !== 'number') {
                throw new Error(name + ' must be a number');
            }
        },
        validateString: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);

            if (typeof val !== 'string') {
                throw new Error(name + ' must be a string');
            }

            if (val.length < 3
                || 25 < val.length) {
                throw new Error(name + ' must be between ' + 3 +
                    ' and ' + 25 + ' symbols');
            }
        }
    };
    // Sorting objects by two parameters!!!!
    function getSortingFunction(firstParameter, secondParameter) {
        return function (first, second) {
            if (first[firstParameter] < second[firstParameter]) {
                return -1;
            }
            else if (first[firstParameter] > second[firstParameter]) {
                return 1;
            }

            if (first[secondParameter] < second[secondParameter]) {
                return -1;
            }
            else if (first[secondParameter] > second[secondParameter]) {
                return 1;
            }
            else {
                return 0;
            }
        }
    }

    var player = function () {
        var lastId = 0;
        var player = {
            init: function (name) {
                this.name = name;
                this.id = lastId += 1;
                this.playlists = [];
                return this;
            },
            get name() {
                return this._name;
            },
            set name(value) {
                if (!isStringValid(value)) {
                    throw {
                        name: 'InvalidNameError',
                        message: 'Name must me a string between 3 and 25 symbols!'
                    }
                }
                this._name = value;
            },
            addPlaylist: function (playlist) {
                validator.validateIfUndefined(playlist);
                validator.validateIfObject(playlist);
                validator.validateIfUndefined(playlist.id);

                this.playlists.push(playlist);
                return this;
            },
            getPlaylistById: function (id) {
                var i,
                    len = this.playlists.length;

                if (typeof id !== 'number') {
                    throw {
                        name: 'InvalidIdError',
                        message: 'Id must be a number!'
                    }
                }

                for (i = 0; i < len; i += 1) {
                    if (this.playlists[i].id === id) {
                        return this.playlists[i];
                    }
                }
                return null;
            },
            removePlaylist: function (value) {
                var i,
                   len = this.playlists.length,
                   index = -1;

                if (typeof value === 'object') {
                    value = value.id;
                }
                else if (typeof value !== 'number') {
                    throw {
                        name: 'InvalidPlayableError',
                        message: 'You must enter either a playable or it\'s ID to remove it!'
                    }
                }

                for (i = 0; i < len; i += 1) {
                    if (this.playlists[i].id === value) {
                        index = i;
                        break;
                    }
                }

                if (index < 0) {
                    throw {
                        name: 'InvalidIDError',
                        message: 'There is no playable with such ID in this playlist!'
                    }
                }

                this.playlists.splice(index, 1);
                return this;
            },
            listPlaylists: function (page, size) {
                var numberOfPlaylists = this.playlists.length;

                page = +page;
                size = +size;
                if (typeof page !== 'number' || page < 0) {
                    throw {
                        name: 'InvalidPageError',
                        message: 'Page must be a non-negative number!'
                    }
                }

                if (typeof size !== 'number' || size <= 0) {
                    throw {
                        name: 'InvalidSizeError',
                        message: 'Size must be a positive number!'
                    }
                }

                if (page * size > numberOfPlayables) {
                    throw {
                        name: 'InvalidPageError',
                        message: 'There is no such page in the playlist!'
                    }
                }

                this.playlists.sort(function (play1, play2) {
                    if (play1.title === play2.title) {
                        return play1.id - play2.id;
                    }
                    return play1.title.localeCompare(play2.title);
                })

                return this.playlists.slice(page * size, (page + 1) * size);
            },
            contains: function (playable, playlist) {

            },
            search: function (pattern) {

            }
        }
        return player;
    }();

    var playlist = function () {
        var lastId = 0;
        var playlist = {
            init: function (name) {
                this.name = name;
                this.id = lastId += 1;
                this.playables = [];
                return this;
            },
            get name() {
                return this._name;
            },
            set name(value) {
                if (!isStringValid(value)) {
                    throw {
                        name: 'InvalidNameError',
                        message: 'Name must me a string between 3 and 25 symbols!'
                    }
                }
                this._name = value;
            },
            //addPlayable: function (playable) {
            //    if (typeof playable.id === 'undefined' || !playable.title) {
            //        throw {
            //            name: 'InvalidPlayableError',
            //            message: 'Playable must have Id and title!'
            //        }
            //    }
            //    this.playables.push(playable);
            //    return this;
            //},
            addPlayable: function (playable) {
                validator.validateIfUndefined(playable);
                validator.validateIfObject(playable);
                validator.validateIfUndefined(playable.id);

                this.playables.push(playable);
                return this;
            },
            getPlayableById: function (id) {
                var i,
                    len = this.playables.length;

                if (typeof id !== 'number') {
                    throw {
                        name: 'InvalidIdError',
                        message: 'Id must be a positive number!'
                    }
                }

                for (i = 0; i < len; i += 1) {
                    if (this.playables[i].id === id) {
                        return this.playables[i];
                    }
                }
                return null;
            },
            //getPlayableById: function (id) {
            //    validator.validateIfUndefined(id);
            //    validator.validateIfNumber(id);

            //    for (i = 0; i < len; i += 1) {
            //        if (this.playables[i].id === id) {
            //            return this.playables[i];
            //        }
            //    }
            //    return null;
            //},
            removePlayable: function (value) {
                var i,
                    len = this.playables.length,
                    index = -1;

                if (typeof value === 'object') {
                    value = value.id;
                }
                else if (typeof value !== 'number') {
                    throw {
                        name: 'InvalidPlayableError',
                        message: 'You must enter either a playable or it\'s ID to remove it!'
                    }
                }

                for (i = 0; i < len; i += 1) {
                    if (this.playables[i].id === value) {
                        index = i;
                        break;
                    }
                }

                if (index < 0) {
                    throw {
                        name: 'InvalidIDError',
                        message: 'There is no playable with such ID in this playlist!'
                    }
                }

                this.playables.splice(index, 1);
                return this;
            },
            listPlayables: function (page, size) {
                var numberOfPlayables = this.playables.length;

                page = +page;
                size = +size;
                if (typeof page !== 'number' || page < 0) {
                    throw {
                        name: 'InvalidPageError',
                        message: 'Page must be a non-negative number!'
                    }
                }

                if (typeof size !== 'number' || size <= 0) {
                    throw {
                        name: 'InvalidSizeError',
                        message: 'Size must be a positive number!'
                    }
                }

                if (page * size > numberOfPlayables) {
                    throw {
                        name: 'InvalidPageError',
                        message: 'There is no such page in the playlist!'
                    }
                }

                this.playables.sort(function (play1, play2) {
                    if (play1.title === play2.title) {
                        return play1.id - play2.id;
                    }
                    return play1.title.localeCompare(play2.title);
                })

                return this.playables.slice(page * size, (page + 1) * size);
            }
        }
        return playlist;
    }();

    var playable = (function () {
        var lastId = 0;
        var playable = {
            init: function (title, author) {
                this.title = title;
                this.author = author;
                this.id = lastId += 1;
                return this;
            },
            play: function () {
                return this.id + '. ' + this.title + ' - ' + this.author;
            },
            get title() {
                return this._title;
            },
            set title(value) {
                if (!isStringValid(value)) {
                    throw {
                        name: 'InvalidTitleError',
                        message: 'Title must be a string between 3 and 25 symbols long!'
                    }
                }
                this._title = value;
            },
            get author() {
                return this._author;
            },
            set author(value) {
                if (!isStringValid(value)) {
                    throw {
                        name: 'InvalidAuthorError',
                        message: 'Author must be a string between 3 and 25 symbols long!'
                    }
                }
                this._author = value;
            }
        }
        return playable;
    }());

    var audio = function (parent) {
        var audio = Object.create(parent);

        audio.init = function (title, author, length) {
            parent.init.call(this, title, author);
            this.length = length;
            return this;
        }

        audio.play = function () {
            return parent.play.call(this) + ' - ' + this.length;
        }

        Object.defineProperty(this, 'length', {
            get: function () {
                return this._length;
            },
            set: function (value) {
                value = +value;
                if (typeof value !== 'number' || value <= 0) {
                    throw {
                        name: 'InvalidLengthError',
                        message: 'Length must be a number greater that 0!'
                    }
                }
                this._length = value;
            }
        });
        return audio;
    }(playable);

    var video = function (parent) {
        var video = Object.create(parent);

        video.init = function (title, author, imdbRating) {
            parent.init.call(this, title, author);
            this.imdbRating = imdbRating;
            return this;
        }

        video.play = function () {
            return parent.play.call(this) + ' - ' + this.imdbRating;
        }

        Object.defineProperty(this, 'imdbRating', {
            get: function () {
                return this._imdbRating;
            },
            set: function (value) {
                value = +value;
                if (typeof value !== 'number' || value < 1 || value > 5) {
                    throw {
                        name: 'InvalidImdbRatingError',
                        message: 'IMDB Rating must e a number must be a number between 1 and 5!'
                    }
                }
                this._imdbRating = value;
            }
        });
        return video;
    }(playable);

    var module = {
        getPlayer: function (name) {
            return Object.create(player).init(name);
        },
        getPlaylist: function (name) {
            return Object.create(playlist).init(name);
        },
        getAudio: function (title, author, length) {
            return Object.create(audio).init(title, author, length);
        },
        getVideo: function (title, author, imdbRating) {
            return Object.create(video).init(title, author, imdbRating);
        }
    };
    return module;
}