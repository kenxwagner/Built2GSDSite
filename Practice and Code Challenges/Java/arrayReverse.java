import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
     Scanner sc = new Scanner(System.in);
     int n = sc.nextInt();
     int[] myArray = new int[n];
        for(int i=0; i<n; i++){
            myArray[i] = sc.nextInt();
        }
        sc.close();
        for(int i=n-1; i>=0; i--){
            System.out.print(myArray[i] + " ");
        }
        
    }
}