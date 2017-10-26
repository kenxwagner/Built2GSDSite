using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericName
{
  class MyProgram
  {
    static void Main(string[] args)
    {
		
		String text = "This is a sentence for testing the word count involved.";
		char[] delimiters = new char[] {' ', '\r', '\n'};
		int n = text.Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length;
		Console.WriteLine(n);
    }
  }

}
