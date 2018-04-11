//fast while loop 
function reverseStr(str) {
  var i = str.length, o = '';
  while (i--) o += str[i];
  return o;
}
 //test
 reverseStr("Hello");