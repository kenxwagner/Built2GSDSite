var sugarBasedAnnouncement = function () { alert("Warning!\n Candy Time!\n\n... End Transmission.")};
sugarBasedAnnouncement();
// that was a function expression

//next up is using the map function
var carBodies = ["Coupe", "Sedan", "Hatchback", "Hybrid", "Truck", "SUV", "Van", "Minivan"];
var carToBuy = carBodies.map( function (carBody) { return "\n" + carBody + "Car Body"; } );
alert(carToBuy);




	//----------------------------------------------------------------------------
	
	
var parkRides =  [["Birch Bumpers", 40], ["Pines Plunge", 55],["Cedar Coaster", 20],["Ferris Wheel of Firs", 90]];
var fastPassQueue =  ["Cedar Coaster", "Pines Plunge", "Birch Bumpers", "Pines Plunge"];
var wantsRide =  "Pines Plunge";
buildTicket (parkRides, fastPassQueue, wantsRide )(); // immediate invocation

function buildTicket (allRides, passRides, ridePick) {
	if(passRides[0] == ridePick){
		var pass = passRides.shift();
		// return the function without storing it.
		return function () { alert("Sweet! You have a Fast Pass to " + pass + "!");
		};
	} else {
		for(var i = 0; i<allRides.length; i++) {
			if (allRides[i][0] == ridePick) { 
				return function () { alert ("A ticket is printing for " + pick + "!\n" +
					"Your wait time is about " + allRides[i][1] + "minutes. ");	 
				};
			}
		}
	}