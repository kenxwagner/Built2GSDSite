//using For loop
function reverseString(str) {
	for (var i = str.length - 1, o = ''; i >= 0; o += str[i--]) { }
	return 0;
}

reverseString("Hello");