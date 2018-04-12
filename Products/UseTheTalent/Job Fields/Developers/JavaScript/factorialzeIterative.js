
function factorialize(num) {
  //edge case
  if (num === 0) {
    return 1;
  }
  var sum = 1;
  while (num > 1) {
    sum *= num;
    num--;
  }
  return sum;
}

factorialize(5);