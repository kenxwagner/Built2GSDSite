using System;
namespace KenFibSeries
{
	class Program
	{
		static int KenFibonRecursive (int n)
		{
			if (num == 0) return 0;
			if (num == 1) return 1;
			return KenFibonRecursive(n-1) + KenFibonRecursive(n-2);
			
		}
		
		static void Main(string[] args)
		{
			Console.Write("What is length of Series?  ");
			int length = Convert.ToInt32(Console.ReadLine());
			for (int count = 0; count < length; count++)
			{
				Console.Write("{0} ", KenFibonRecursive(count));
			}
			Console.ReadKey();
		
		
		
		}
	}


}