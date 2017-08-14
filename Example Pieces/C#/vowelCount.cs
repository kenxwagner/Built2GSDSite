using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppVowelCount
{
	class Program
	{
		static void Main(string[]args)
		{
			Console.WriteLine("Give me a string:");
			string input1 = Console.ReadLine();
			char[] ch = input1.ToCharArray();
			int count = 0;
			foreach(var i in ch)
			{
				if (i >='a'&&i<='z')
				{
					if(i=='a' ||i=='e' ||i=='i' ||i=='o' ||i=='u')
					{
						count++;
					}
				}
			}
			Console.WriteLine(count);
			Console.Read();
		}
	}
}
