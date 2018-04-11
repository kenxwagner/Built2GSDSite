(() => {
 
     
    let reverse1 = s => Array.from(s)
        .reduceRight((a, x) => a + (x !== ' ' ? x : ' <- '), ''),
 // chained
        reverse2 = s => s.split('').reverse().join('');
 
 
    return [reverse1, reverse2]
        .map(f => f("Some string to be reversed"));
 
})();