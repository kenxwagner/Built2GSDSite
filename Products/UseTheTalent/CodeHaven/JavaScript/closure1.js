 var add = (function () {
    var counter = 2;
    return function () {return counter += 1;}
})();

add();
add();
add();
add();
// the counter is now 7 