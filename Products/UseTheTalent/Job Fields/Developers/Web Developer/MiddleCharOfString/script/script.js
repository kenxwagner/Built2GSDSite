function getMiddle(s) {
  return s.length % 2 ? s.substr(s.length / 2, 1) : s.substr((s.length / 2) - 1, 2);
}

// I/O stuff
document.getElementById("submit").addEventListener("click", function() {
	input = document.getElementById("input").value;
	document.getElementById("output").innerHTML = getMiddle(input);
});