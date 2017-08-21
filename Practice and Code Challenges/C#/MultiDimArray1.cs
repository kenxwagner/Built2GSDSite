using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimArray1
{
  class MyProgram
  {
    static void Main(string[] args)
    {
		int [ , ] someNums = { {2,3}, {5,6}, {4,6} };
		for (int k = 0; k < 3; k++) {
			for (int j = 0; j <2; j++)
	{
		 Console.WriteLine("Welcome to the World!");
		  Console.Write(someNums[k, j]+" ");
	}
		
    Console.WriteLine("Welcome to the World!");
    
  }

}
