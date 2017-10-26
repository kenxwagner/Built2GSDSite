function sumOfMultiple {
  var sum = 0;
  for (var n = 0; n < 10; n++) {
  if (n % 3 === 0 || n % 5 ===0) {
      sum +=n;
      }
    }
    return sum;
}
document.getElementById('result1').innerHTML=sumOfMultiple();
console.log(sumOfMultiple);
