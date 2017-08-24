import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
       Scanner in = new  Scanner(System.in);
       int myArray[][] = new int[6][6];
        for (int i = 0; i < 6; i++){
           for(int j = 0; j < 6; j++)
               myArray[i][j] = in.nextInt();       
       }
        int max = Integer.MIN_VALUE;
        int sum;
        
        for(int i = 0; i <= 3; i++){
            for(int j = 0; j <= 3; j++){
                sum = myArray[i + 1][j + 1];
                for(int k = j; k < j + 3; k++){
                    sum += myArray[i][k] + myArray[i + 2][k];
                }            
                if(sum > max)
                    max = sum;
            }
        }
        
        System.out.print(max);
    }
}