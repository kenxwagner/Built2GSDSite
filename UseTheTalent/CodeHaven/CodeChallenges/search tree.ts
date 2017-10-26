function binary_search_recursive(a, value, low, high) {
  if (high < low) { return null; }
 
  var mid = Math.floor((low + high) / 2);
 
  if (a[mid] > value) {
    return binary_search_recursive(a, value, low, mid - 1);
  }
  if (a[mid] < value) {
    return binary_search_recursive(a, value, mid + 1, high);
  }
  return mid;
}
