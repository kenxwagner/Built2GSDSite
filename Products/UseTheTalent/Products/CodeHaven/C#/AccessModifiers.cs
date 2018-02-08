using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericName
{
  class MyModifiers
  {
    static void Main(string[] args)
    {
		
		String text1 = "public - The type or member can be accessed by any other code in the same assembly or another assembly that references it.";
		String text2 = "private - The type or member can only be accessed by code in the same class or struct.";
		String text3 = "protected - The type or member can only be accessed by code in the same class or struct, or in a derived class.";
		String text4 = "internal - The type or member can be accessed by any code in the same assembly, but not from another assembly.";
		String text5 = "protected internal - The type or member can be accessed by any code in the same assembly, or by any derived class in another assembly.";
		
		Console.WriteLine(text1);
		char[] delimiters = new char[] {' ', '\r', '\n'};
		int a = text1.Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length;
		Console.WriteLine(a);
		
		Console.WriteLine(text1);
		char[] delimiters = new char[] {' ', '\r', '\n'};
		int b = text2.Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length;
		Console.WriteLine(b);
		
		Console.WriteLine(text1);
		char[] delimiters = new char[] {' ', '\r', '\n'};
		int c = text3.Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length;
		Console.WriteLine(c);
		
		Console.WriteLine(text1);
		char[] delimiters = new char[] {' ', '\r', '\n'};
		int d = text4.Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length;
		Console.WriteLine(d);
		
		Console.WriteLine(text1);
		char[] delimiters = new char[] {' ', '\r', '\n'};
		int e = text5.Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length;
		Console.WriteLine(e);
    }
  }

}
