var arr = [5,1],[3,12],[21,-1,2]
	
function multiplyAll(arr) {
  var product = 1;
  
  for (i=0; i<arr.length; i++){
    for (j=0; j<arr[i].length; j++){
    product*=(arr[i][j]);
  }
  }
  // Only change code above this line
  return product;
}

// Modify values to test code
multiplyAll([[5,1],[3,12],[0.2,1,2]]);