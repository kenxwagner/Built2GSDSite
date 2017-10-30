/* Given a time in -hour AM/PM format, convert it to military (-hour) time.

Note: Midnight is on a -hour clock, and on a -hour clock. Noon is on a -hour clock, and on a -hour clock.

Input Format

A single string containing a time in -hour clock format (i.e.: or ), where and .

Output Format

Convert and print the given time in -hour format, where .

Sample Input

07:05:45PM

Sample Output

19:05:45
 */


import java.io.*;
import java.util.*;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner scanner = new Scanner(System.in);
        String inputTime = scanner.next();
        scanner.close();
        LocalTime localTime = LocalTime.parse(inputTime, DateTimeFormatter.ofPattern("hh:mm:ssa"));
        String militaryFormattedTime = localTime.format(DateTimeFormatter.ofPattern("HH:mm:ss"));
        System.out.println(militaryFormattedTime);
    }
}