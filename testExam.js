var module = (function() {
    function validateString(value) {
        if (value.length < 3 || value.length > 25) {
            throw new Error('invalide string length');
        }
    }

    function ValidateLength(value) {
        if (value <= 0) {
            throw new Error('length must be greater than 0')
        }
    }

    function validateImdbRating(value) {
        if (value < 1 || value > 5) {
            throw new Error('invalid imdb Rating')
        }
    }

    var playable = (function() {
        var playable = {};

        Object.defineProperties(playable, {
            init: {
                value: function(title, author) {
                    this.title = title;
                    this.author = author;
                    this.id = Math.random();
                    return this;
                }
            },

            play: {
                value: function() {
                    return this.id + '. ' + this.title + ' - ' + this.author;
                }
            },

            title: {
                get: function() {
                    return this._title;
                },
                set: function(newTitle) {
                    validateString(newTitle);
                    this._title = newTitle;
                }
            },

            author: {
                get: function() {
                    return this._author;
                },
                set: function(newAuthor) {
                    validateString(newAuthor);
                    this._author = newAuthor;
                }
            }
        })
        return playable;
    }());

    var audio = (function(parent) {
        var audio = Object.create(parent);

        Object.defineProperties(audio, {
            init: {
                value: function(title, author, length) {
                    parent.init.call(this, title, author);
                    this.length = length;
                    return this;
                }
            },

            length: {
                get: function() {
                    return this._length;
                },
                set: function(value) {
                    ValidateLength(value);
                    this._length = value;
                }
            },

            play: {
                value: function() {
                    return parent.play.call(this) + ' - ' + this.length;
                }
            }
        })

        return audio;
    }(playable));

    var video = (function(parent) {
        var video = Object.create(parent);

        Object.defineProperties(video, {
            init: {
                value: function(title, author, imdbRating) {
                    parent.init.call(this, title, author);
                    this.imdbRating = imdbRating;
                    return this;
                }
            },

            imdbRating: {
                get: function() {
                    return this._imdbRating;
                },
                set: function(value) {
                    validateImdbRating(value);
                    this._imdbRating = value;
                }
            },

            play: {
                value: function() {
                    return parent.play.call(this) + ' - ' + this.imdbRating;
                }
            }
        });

        return video;
    }(playable));

    var playList = (function () {
        var playList = {};

        Object.defineProperties(playList,{
            init:{
                value:function (name) {
                    this.name = name;
                    this.id = Math.random();
                    this.playables = [];
                    return this;
                }
            },
                name:{
                    get :function () {
                        return this._name;
                    },
                    set:function (value) {
                        validateString(value);
                        this._name = value;
                    }
                },
                addPlayable:{
                    value:function (playable) {
                        this.playables.push(playable)
                        return this;
                    }
                },
                getPlayableById:{
                    value:function (id) {
                        for (var i = 0; i < this.playables.length; i+=1) {
                            if (this.playables[i].id === id) {
                                return this.playables[i];
                            }
                        }
                        return null;
                    }
                },
                removePlayable:{
                    value:function (id) {
                        var arr = [];
                        if (!this.playables.some(function (x) {
                            return x.id === id;
                        })) {
                            throw new Error('not have playable with this id');
                        }
                        for (var i = 0; i < this.playables.length; i+=1) {
                            if (this.playables[i].id !== id) {
                                arr.push(this.playables[i]);
                            }
                        }
                        this.playables = arr.slice();
                        return this;
                    }
                }
        })

        return playList;
    }());

    var favourite = Object.create(playList).init('Rock');
    var movie1 = Object.create(video).init('azzz','rras',5);
    var music1 = Object.create(audio).init('ggggf','sds',3.21);
    var music2 = Object.create(audio).init('fdasfd1','ogii',3);
    var movie2 = Object.create(video).init('mmmn','kool',1.5);
    //favourite.addPlayable(movie1);
    favourite.addPlayable(movie2);
    favourite.addPlayable(music1);
    favourite.addPlayable(music2);
    favourite.addPlayable(music2);
    var id = music1.id;
    console.log(id);
    console.log(favourite.removePlayable(id));
    //console.log(favourite);

    return {
        getPlayer: function(name) {
            return 1;
        },
        getPlaylist: function(name) {
            return 1;
        },
        getAudio: function(title, author, length) {
            return Object.create(audio).init(title, author, length)
        },
        getVideo: function(title, author, imdbRating) {
            return Object.create(video).init(title, author, imdbRating)
        }
    };
}());
