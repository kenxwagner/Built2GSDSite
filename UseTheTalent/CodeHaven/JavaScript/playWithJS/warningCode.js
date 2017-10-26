// let's use closure
function giveWarning(problem) {
	var count = 0;
	var areas = [];
	return function (number, location) {
		count++;
		var list = "";
		areas.push([location, number]);
		for (var i = 0; i < areas.length; i++) {
			
			list +=areas[i][0] + " (" + areas[i][1] + ")" + "\n";
		}
    alert("Beware! There have been " + problem +
          " sightings in the Cove today!\n" +
          number + " have been spotted at the " +
          location + "!\n" +
          "This is notice #" + count +
          " today for " + problem + " danger.\n" +
          "Known danger areas are:\n" +
          list);
  };
}
