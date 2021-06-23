using System;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matrixSize = Console.ReadLine().Split().ToArray(); ;
            string grow = "Bloom Bloom Plow";
            int[,] matrix = new int[int.Parse(matrixSize[0].ToString()), int.Parse(matrixSize[1].ToString())];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }
            string[] input = new string[2];
            while (true)
            {
                input = Console.ReadLine().Split().ToArray();
                if (string.Join(' ', input) == grow)
                {
                    break;
                }
                int row = int.Parse(input[0]);
                int col = int.Parse(input[1]);
                if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                else
                {
                for (int i = 0; i < matrix.GetLength(1); i++)
                    {
                        matrix[row, i] += 1;
                    }
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix[i, col] += 1;

                    }
                    matrix[row, col]--;
                }
               
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    Console.Write(matrix[i,l] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
