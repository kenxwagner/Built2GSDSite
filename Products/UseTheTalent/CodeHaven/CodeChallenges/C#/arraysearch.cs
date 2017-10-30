using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace MakeASearchArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strname = { "Miller", "Moana", "Tahiti", "Coconut", "Shiny" };
            string match = Array.Find(strname, ContainsA);
            Console.WriteLine("Search string is:" + match);
        }
        static bool ContainsA(string findname)
        {
            return findname.Contains("a");
        }
    }
}

 