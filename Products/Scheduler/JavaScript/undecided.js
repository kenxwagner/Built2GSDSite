
// Example
var userSkillArr = [ "Painter", "Artist", "Decorator"];


for (var i = 0; i < userSkillArr.length; i++) {
  Console.log(userSkillArr[i]);
}

// Setup
var userRatingsArr = [ 4, 3, 4, 5, 5];

// Only change code below this line
var ratingAVG = 0;
for (var i = 0; i < userRatingsArr.length; i++) {
  ratingAVG += userRatingsArr[i];
}
	ratingAVG = ratingAVG/(userRatingsArr.length+1);

