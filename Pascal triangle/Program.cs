using System;
using System.Linq;
namespace Pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            UInt64[][] triangle = new UInt64[rows][];
            for (int i = 0; i < rows; i++)
            {
                triangle[i] = new UInt64[i + 1];
                if (rows < 3)
                {
                    for (int l = 0; l < triangle[i].Length; l++)
                    {
                        triangle[i][l] = 1;
                    }
                }
                else
                {
                    for (int l = 0; l < triangle[i].Length; l++)
                    {
                        if (l == 0)
                        {
                            triangle[i][l] = 1;
                        }
                        else if (l >=1 && l <= triangle[i].Length - 2)
                        {
                            triangle[i][l] = triangle[i - 1][l] + triangle[i - 1][l - 1];
                        }
                        else if (l == triangle[i].Length-1)
                        {
                            triangle[i][l] = 1;
                        }
                    }
                }
            }
            for (int i = 0; i < triangle.Length; i++)
            {
                Console.WriteLine(string.Join(' ', triangle[i]).ToArray()); 
            }
        }
    }
}
