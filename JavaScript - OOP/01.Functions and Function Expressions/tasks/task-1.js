/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(arr) {
	if (arr.length === 0) {
		return null;
	}
	var sum = 0;
	for (var index = 0; index < arr.length; index+=1) {
		var element = parseInt(arr[index]);
		if (isNaN(element)) {
			throw new Error();
			return;
			
		}
		sum += element;
	}
	
	return sum;
}

module.exports = sum;