using System;
using System.Linq;
namespace Symbol_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rows, rows];
            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();
                for (int l = 0; l < input.Length; l++)
                {
                    matrix[i, l] = input[l];
                }
            }
            char a = char.Parse(Console.ReadLine());
            bool isFound = false;
            for (int i = 0; i < rows; i++)
            {
                for (int l = 0; l < rows; l++)
                {
                    if (a == matrix[i,l])
                    {
                        Console.WriteLine($"({i}, {l})");
                        isFound = true;
                    }
                }
            }
            if (isFound == false)
            {
                Console.WriteLine($"{a} does not occur in the matrix");
            }
        }
    }
}
