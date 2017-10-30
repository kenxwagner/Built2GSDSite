using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenFibSeries
{
    class Program
    {
        static int KenFibSeries(int num)
        {
            int numberFirst = 0;
            int numberSecond = 1;
            int outcome = 0;

            if (num == 1) return 1;
            if (num == 0) return 0;

            for (int count = 2; count <= num; count++)
            {
                outcome = numberFirst + numberSecond;
                numberFirst = numberSecond;
                numberSecond = outcome;
            }

            return outcome;
        }

        static void Main(string[] args)
        {
            Console.Write("What is length of Series?  ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int count = 0; count < length; count++)
            {
                Console.Write("{0} ", KenFibSeries(count));
            }
            Console.ReadKey();



        }
    }
}
