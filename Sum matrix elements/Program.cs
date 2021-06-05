using System;
using System.Linq;
using System.Collections.Generic;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] input = new int[matrixSize[1]];
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            for (int i = 0; i < matrixSize[0]; i++)
            {
                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int l = 0; l < matrixSize[1]; l++)
                {
                    matrix[i, l] = input[l];
                }
            }
            int sum = 0;
            for (int i = 0; i < matrixSize[0]; i++)
            {
                for (int k = 0; k < matrixSize[1]; k++)
                {
                    sum += matrix[i, k];
                }
            }
            Console.WriteLine(matrixSize[0]);
            Console.WriteLine(matrixSize[1]);
            Console.WriteLine(sum);
        }
    }
}
