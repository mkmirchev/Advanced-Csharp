using System;
using System.Linq;
using System.Collections.Generic;

namespace Sum_Matrix_Colums
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
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int l = 0; l < matrixSize[1]; l++)
                {
                    matrix[i, l] = input[l];
                }
            }
            int[] output = new int[matrixSize[1]];
            for (int i = 0; i < matrixSize[0]; i++)
            {
                output[i] = 0;
            }
            for (int i = 0; i < matrixSize[0]; i++)
            {
                for (int k = 0; k < matrixSize[1]; k++)
                {
                    output[k] += matrix[i, k];
                }
            }
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
