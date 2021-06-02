using System;
using System.Collections.Generic;
using System.Linq; 
namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int temp;
            int[,] matrix = new int[a,a];
            //reading input and generating matrix
            for (int i = 0; i < a; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int l = 0; l < a; l++)
                {
                    temp = input[l];
                    matrix[i, l] = temp;
                }
            }
            //summing two diagonals
            int firstD = 0;
            int secondD = 0;
            int tmp = a - 1;
            for (int i = 0; i < a; i++)
            {
                firstD += matrix[i, i];
                secondD += matrix[tmp, i];
                tmp--;
            }

            //generation output
            int output = firstD - secondD;
            Console.WriteLine(Math.Abs(output));
        }
    }
}
