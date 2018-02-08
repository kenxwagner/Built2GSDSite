using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using.System.Threading.Tasks;

namespace ConsoleApplication2
{
	class Program
	{
		static void Main(string[] args)
		{
		
			// play with data types
			bool canCode = true;
			
			char grade = 'A';
			
			int maxInt = int.MaxValue;
			
			long maxLong = long.MaxValue;
			
			decimal maxDec = decimal.MaxValue;
			
			float maxFloat = float.MaxValue;
			
			double maxDouble = double.MaxValue;
			
			Console.WriteLine("Max int: " + maxInt);
			
			var someName = "Rose";
		
			Console.WriteLine("someName is a {0}", someName.TypeCode());
			
			//Time for math:
			
			Console.WriteLine("9+2= "+ (9+2));
			Console.WriteLine("9-2= "+ (9-2));
			Console.WriteLine("9*2= "+ (9*2));
			Console.WriteLine("9/2= "+ (9/2));
			Console.WriteLine("9%2= "+ (9%2));
			
			int k = 1;
			
			Console.WriteLine("k++ = " + (k++));
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			
			
		}
	
	}
	

}