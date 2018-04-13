using System;
 
class Solution {
 
    static int res = 0;
    static int checkRecursive(int num, int x,
                                int k, int n)
    {
        if (x == 0) 
            res++;
         
        int r = (int)Math.Floor(Math.Pow(num, 1.0 / n));
 
        for (int i = k + 1; i <= r; i++) 
        {
            int a = x - (int)Math.Pow(i, n);
        if (a >= 0)
            checkRecursive(num, x - 
                          (int)Math.Pow(i, n), i, n);
        }
        return res;
    }
 
    static int check(int x, int n)
    {
        return checkRecursive(x, x, 0, n);
    }
    public static void Main()
    { 
        Console.WriteLine(check(10, 2));
    }
}