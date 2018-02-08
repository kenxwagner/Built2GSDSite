function someClosure() {
	var x = 4;
	function closeX () {
		return x;
	}
	return closeX;
}

var someLocalFoo = someClosure();

someLocalFoo();

// creating more efficient functions

function buildSomeTicketMaker (transport) {
	return function ( name ) {
		alert("Here is your ticket for riding the " + transport + ".\n" + 
				"Welcome to Closer Transport, " + name + "!");
	}
}

// create items to ride
var getHorseRide = buildSomeTicketMaker("Horse");
var getCarRide = buildSomeTicketMaker("Herbie the Love Bug");
var getBalloonRide = buildSomeTicketMaker("Hot Air Balloon");

getHorseRide("Rapunzel");
getCarRide("Garfield");
getBalloonRide("Mickey");
