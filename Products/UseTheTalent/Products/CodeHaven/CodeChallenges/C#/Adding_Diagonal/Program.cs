using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adding_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = {
                {12,25,144,13,19},
                {150,62,72,82,92},
                {1,2,3,4,5},
                {99,98,97,96,95},
                {75,25,50,100,0}};

            int rowlength = num.GetLength(0);
            int columnlength = num.GetLength(1);
            int total = 0;
            Console.Write("The Diagonals are : ");
            for(int row=0; row<rowlength; row++)
            {
                for(int column=0; column<columnlength; column++)
                {
                    if (row == column)
                    {
                        Console.Write(num[row, column] + " ");
                        total += num[row, column];
                    }

                }

            }
            Console.WriteLine(": Sum : " + total);
        }
    }
}
