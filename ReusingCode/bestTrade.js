
function bestTrade(input) {
    var prices = input.split(' ').map(Number), maxWin = [0, 0];
    for (var i = 0; i < prices.length - 2; i++) {
        for (var j = i + 2; j < prices.length; j++) {
            if (prices[j] - prices[i] > maxWin[1] - maxWin[0])
                maxWin = [prices[i], prices[j]];
        }
    }
    return maxWin;
}
