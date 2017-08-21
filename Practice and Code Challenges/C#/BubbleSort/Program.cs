using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] givenData = { 150, 25, 42, 5, 13, 95, 78, 115 };
            bool flag = true;
            int temp;
            int numLength = givenData.Length;

            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (givenData[j + 1] > givenData[j])
                    {
                        temp = givenData[j];
                        givenData[j] = givenData[j + 1];
                        givenData[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            foreach(int num in givenData)
            {
                Console.Write("\t{0}", num);
            }
            Console.Read();

        }
    }
}
