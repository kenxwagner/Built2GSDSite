using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[14];

            num[0] = 7;
            num[1] = 15;
            num[2] = 23;
            num[3] = 19;
            num[4] = 66;
            num[5] = 42;
            num[6] = 12;
            num[7] = 25;
            num[8] = 32;
            num[9] = 10;
            num[10] = 29;
            num[11] = 2;
            num[12] = 8;
            num[13] = 13;

            Console.WriteLine("1st value: \t{0}", num[0]);
            Console.WriteLine("2nd value: \t{0}", num[1]);
            Console.WriteLine("3rd value: \t{0}", num[2]);
            Console.WriteLine("4th value: \t{0}", num[3]);
            Console.WriteLine("5th value: \t{0}", num[4]);
            Console.WriteLine("6th value: \t{0}", num[5]);
            Console.WriteLine("7th value: \t{0}", num[6]);
            Console.WriteLine("8th value: \t{0}", num[7]);
            Console.WriteLine("9th value: \t{0}", num[8]);
            Console.WriteLine("10th value: \t{0}", num[9]);
            Console.WriteLine("11th value: \t{0}", num[10]);
            Console.WriteLine("12th value: \t{0}", num[11]);
            Console.WriteLine("13th value: \t{0}", num[12]);
            Console.WriteLine("14th value: \t{0}", num[13]);

            Console.ReadLine();

        }
    }
}
