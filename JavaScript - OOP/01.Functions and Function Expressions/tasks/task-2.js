/* Task description */
/*
	Write a function a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `string`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(a,b) {
	var from = +a,
		to = +b,
		result = [];
			
	if (isNaN(from) || isNaN(to)) {
		throw new Error();
	}
	
	for (var counter = from; counter <= to; counter+=1) {
		if(counter === 1){continue;}
    	var notPrime = false;
		
	    for (var i = 2; i <= counter; i+=1) {
	        if (counter % i === 0 && i!==counter) {
	            notPrime = true;
	        }
	    }
	    if (notPrime === false) {
	    	result.push(counter);
	    }
	}
		
	return result;
}

module.exports = findPrimes;