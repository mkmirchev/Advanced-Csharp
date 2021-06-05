using System;
using System.Linq;
namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[] input = new int[matrixSize];
            int[,] matrix = new int[matrixSize, matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int l = 0; l < matrixSize; l++)
                {
                    matrix[i, l] = input[l];
                }
            }
            while (true)
            {
                 string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
               
                if (command[0] == "END")
                {
                    break;
                }
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int val = int.Parse(command[3]);
                bool isOutside = false;
                if (row >= matrixSize || col >= matrixSize || row < 0 || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    isOutside = true;
                }
                if (command[0] == "Add" && isOutside == false)
                {
                    matrix[int.Parse(command[1]), int.Parse(command[2])] += int.Parse(command[3]);
                }
                else if (command[0] == "Subtract" && isOutside == false)
                {
                    matrix[int.Parse(command[1]), int.Parse(command[2])] -= int.Parse(command[3]);
                }
            }
            for (int i = 0; i < matrixSize; i++)
            {
                int[] temp = new int[matrixSize];
                for (int k = 0; k < matrixSize; k++)
                {
                    temp[k] = matrix[i, k];
                }
                Console.WriteLine(string.Join(' ', temp));
            }
       
        }
    }
}
