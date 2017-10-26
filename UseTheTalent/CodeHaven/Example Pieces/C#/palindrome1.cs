using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Oh, the palindrome. It reads the same backword or forward.
*/
namespace PalindromeTime
{
  class MyProgram
  {
    static void Main(string[] args)
    {
		int num = 24542; // example
		//Console.ReadLine();
		int number =  num;
		int rem, reversed = 0;
		// reversing it
		while (num > 0)
		{
			rem = num % 10;
			reverse = reversed * 10 + rem;
			num = num /10;
		}
		if (number == reversed)
		{
			Console.WriteLine(number + " is a Palindrome");
		}
		else
		{
			Console.WriteLine(number + " is not a Palindrome");
		}
    Console.WriteLine("Welcome to the World!");
    }
  }

}
