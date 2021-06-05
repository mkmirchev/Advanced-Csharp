using System;
using System.Linq;

namespace Square_with_maximum_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mtx = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[mtx[0], mtx[1]];
            int[] input = new int[mtx[0]];
            for (int i = 0; i < mtx[0]; i++)
            {
                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int l = 0; l < mtx[1]; l++)
                {
                    matrix[i, l] = input[l];
                }
            }
            int[,] maxMtx = new int[2, 2];
            int maxMtxSum = 0;
            int temp = 0;
            for (int i = 0; i < mtx[0]-1; i++)
            {
                for (int l = 0; l < mtx[1]-1; l++)
                {
                    temp = matrix[i, l] + matrix[i, l + 1] + matrix[i + 1, l] + matrix[i + 1, l + 1];
                    if (temp > maxMtxSum)
                    {
                        maxMtxSum = temp;
                        maxMtx[0, 0] = matrix[i, l];
                        maxMtx[0, 1] = matrix[i, l + 1];
                        maxMtx[1, 0] = matrix[i + 1, l];
                        maxMtx[1, 1] = matrix[i + 1, l + 1];

                    }
                }
            }
            Console.WriteLine(maxMtx[0,0] + " " + maxMtx[0, 1]);
            Console.WriteLine(maxMtx[1,0] + " " + maxMtx[1, 1]);
            Console.WriteLine(maxMtxSum);
        }
    }
}
