using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
  class MyProgram
  {
    static void Main(string[] args)
    {
		needInput = Console.ReadLine();
		
		if (needInput%2 == 0)
			Console.WriteLine("The number is even!");
			else
			Console.WriteLine("The number is odd!");
    }
  }

}
