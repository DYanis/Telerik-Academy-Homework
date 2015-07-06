/* Task Description */
/*
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/
function solve() {
	var Course = {
		init: function (title, presentations) {
			if (!validTitle(title)) {
				Err('course tittle');
			}
			if (presentations.length < 1) {
				Err('no presentations');
			}
			for (var i in presentations) {
				if (!validTitle(presentations[i])) {
					Err('presentation tittle');
				}
			}
			this.title = title;
			this.presentations = presentations;
			this.students = [];
			this.examResults=[];
			return this;
		},
		addStudent: function (name) {
			var names = name.split(' ');
			if (names.length > 2) {
				Err('Number of Names');
			}
			if (!validName(names[0])) {
				Err('FristName');
			}
			if (!validName(names[1])) {
				Err('SecondName');
			}
			var id = this.students.length + 1;
			//var student = {};
			var student = createStudent(names[0], names[1]);
			student.id = id;
			this.students.push(student);
			return id;
		},
		getAllStudents: function () {
			return this.students.slice(0);
		},
		submitHomework: function (studentID, homeworkID) {
			if (studentID > this.students[this.students.length - 1].id || studentID < 1) {
				Err('invalid stundent id');
			}
			if (homeworkID < 1 || homeworkID > this.presentations.length) {
				Err('invalid homeworkid');
			}
		},
		pushExamResults: function (results) {
			checkResults(results);
			//this.examResults=results;
			return this;
		},
		getTopStudents: function () {
		}
	};

	function validTitle(title) {
		return title[0] !== ' ' && title[title.length - 1] !== ' ' && !/\s{2,}/g.test(title) && title;
	}

	function validName(name) {
		var symbol;
		for (var j = 0, l = name.length; j < l; j += 1) {
			symbol = name.charAt(j);
			if (j === 0) {
				if (!letterIsUppercase(symbol)) {
					return false;
				}
			} else {
				if (letterIsUppercase(symbol)) {
					return false;
				}
			}
		}
		return true;
	}
	function checkResults(results){
		if(results.length<1){
			Err('emptyArray');
		}
		var usedIds=[];
		var max=this.students[this.students.length];
		for(var k in results){
			var studentID=results[k].StudentID;
			var score=results[k].score;
			if (studentID > max || studentID < 1 && usedIds.indexOf(studentID)===-1) {
				Err('invalid stundent id');
			}
			if(!isNaN(score)){
				Err('Invalid Score');
			}
		}
	}

	Object.defineProperty(Course, 'title', {
		get: function () {
			return Course._title;
		},
		set: function (title) {
			Course._title = title;
		}
	});

	Object.defineProperty(Course, 'presentations', {
		get: function () {
			return Course._presentations;
		},
		set: function (presentations) {
			Course._presentations = presentations;
		}
	});

	Object.defineProperty(Course, 'students', {
		get: function () {
			return Course._students;
		},
		set: function (students) {
			Course._students = students;
		}
	});
	Object.defineProperty(Course, 'examResults', {
		get: function () {
			return Course._examResults;
		},
		set: function (value) {
			Course._examResults = value;
		}
	});

	function letterIsUppercase(letter) {
		return letter === letter.toUpperCase();
	}

	function Err(message) {
		throw  new Error(message);
	}

	function createStudent(firstName, lastName) {
		return {
			firstname: firstName,
			lastname: lastName
		};
	}

	return Course;
}

module.exports = solve;
