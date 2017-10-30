using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysVersion1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(5);

            list[0] = 2;

            Console.WriteLine(list[0]);

            int[] plainArray = new int[9];

            plainArray[0] = 1;
            plainArray[1] = 3;
            Console.WriteLine(plainArray[0]);

        }
    }
}
