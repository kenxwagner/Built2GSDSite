using System;
using System.Collections.Generic;
using System.Linq;
class Solution {
    public int solution(int[] A) {
        // set up for sums
      int sum = 0;
      int left = 0;
      int right = 0;
      
      for (int i = 0; i <A.Length; i++)
      {
          sum+=A[i];
                }
       for (int i = 0; i <A.Length; i++)
       {
           right = sum - left -A[i];
           if(right == left)
                    return i;
            left +=A[i];
       }
    return -1;
            
        
    }
}

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
