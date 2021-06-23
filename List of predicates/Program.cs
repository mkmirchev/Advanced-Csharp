using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int, List<int>> customFunc = CustomFunc;
            List<int> CustomFunc(int[] arr , int value)
            {
                List<int> output = new List<int>();
                for (int i = 1; i <= value; i++)
                {
                    bool[] isDivisible = new bool[arr.Length];
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (i % arr[j] == 0)
                        {
                            isDivisible[j] = true;
                        }
                        else
                        {
                            isDivisible[j] = false;
                        }
                    }
                    if (!isDivisible.Contains(false))
                    {
                        output.Add(i);
                    }
                }
                return output;
            }
            Console.WriteLine(string.Join(' ',CustomFunc(arr,number)));
        }
    }
}
