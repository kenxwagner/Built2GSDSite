(function(x) {
 
  var memo = {};
 
  function factorial(num) {
    return num < 2 ? 1 : memo[num] || (memo[num] = num * factorial(num - 1));
  }
 
  return factorial(x);
 
})(15);