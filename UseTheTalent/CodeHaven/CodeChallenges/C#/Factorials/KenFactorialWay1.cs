using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

nameSpace KenFactorialWay1
{
	class Program
	{
		static int Facto(int n)
		{
			if(n==1){
				return 1;
			}
			return n * Facto(x-1);
		}
		
		static void Main(string[] args)
		{
			int o = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Here we find the factorial of " + o + " is " + Facto(o));
		}
	}
}