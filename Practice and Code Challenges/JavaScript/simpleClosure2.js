function somethingName (firstName){
	var someIntro = "This celebrity is known as ";
	//now this function has access to the outer function's variables, including the parameter
function lastNameCall(theLastName){
	return someIntro + firstName + " " + theLastName;
}
return lastNameCall;
}
	
var mjName = somethingName("John");// At this juncture, the somethingName outer function has returned.​
	​
	​// The closure (lastNameCall) is called after the outer function has returned above​
	​// Yet, the closure still has access to the outer function's variables and parameter​
	mjName ("Wayne"); // This celebrity is John Wayne
	
	//Closures have access to the outer function’s variable even after the outer function returns