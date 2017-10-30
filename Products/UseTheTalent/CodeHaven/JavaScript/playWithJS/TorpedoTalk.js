function assignTorpedo( name, passengerArray ) {
	var torpedoAssignment;
	for (var i = 0; i < passengerArray.length; i++) {
		if (passengerArray[i] == name) {
			torpedoAssignment = function ( ) {
				alert("Yo! Dude, " + name + "!\n" + "Man your post at Torpedo #" + (i+1) + "!");
				};
		}
	}
	return torpedoAssignment; // gets called after loop is finished.
}

var subPassengers = ["Luke", "Leia", "Han, "Chew", "yo", "r2", "c", "Bo"];
var giveAssignment = assignTorpedo("Chew", subPassengers);
giveAssignment();

// fixed this way
function assignTorpedo( name, passengerArray ) {
	
	for (var i = 0; i < passengerArray.length; i++) {
		if (passengerArray[i] == name) {
			return function ( ) {
				alert("Yo! Dude, " + name + "!\n" + "Man your post at Torpedo #" + (i+1) + "!");
				};
		}
	}
	
}

var subPassengers = ["Luke", "Leia", "Han, "Chew", "yo", "r2", "c", "Bo"];
var giveAssignment = assignTorpedo("Chew", subPassengers);
giveAssignment();


// Also fixed this way
function makeTorpedoAssigner( passengerArray ) {
	return function ( name ) { 
		for (var i = 0; i < passengerArray.length; i++) { // i is now local
			if (passengerArray[i] == name) {
				
					alert("Yo! Dude, " + name + "!\n" + "Man your post at Torpedo #" + (i+1) + "!");
		}
	}
	};
}

var subPassengers = ["Luke", "Leia", "Han, "Chew", "yo", "r2", "c", "Bo"];
var getTorpedoFor = makeTorpedoAssigner(subPassengers);
getTorpedoFor("Chew");



function assignLaser(shark, sharkList) {
  var stationAssignment;
  for (var i = 0; i < sharkList.length; i++) {
    if (shark == sharkList[i]) {
      stationAssignment = function() {
        alert("Yo, " + shark + "!\n" +
              "Visit underwater strapping station " +
              (i + 1) + " for your sweet laser.");
      };
    }
  }
  return stationAssignment;
}


function assignLaser(shark, sharkList) {
  var stationAssignment;
  for (var i = 0; i < sharkList.length; i++) {
    if (shark == sharkList[i]) {
      stationAssignment = function() {
        alert("Yo, " + shark + "!\n" +
              "Visit underwater strapping station " +
              (i + 1) + " for your sweet laser.");
      };
    }
  }
  return stationAssignment;
}


