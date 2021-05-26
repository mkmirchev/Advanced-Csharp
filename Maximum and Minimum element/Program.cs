using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int readings = int.Parse(Console.ReadLine());
            Stack<int> stck = new Stack<int>();
            for (int i = 0; i < readings; i++)
            {
                int[] currentData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (currentData.Count() == 2)
                {
                    stck.Push(currentData[1]);
                }
                else
                {
                    if (currentData[0] == 2 && stck.Count() > 0)
                    {
                        stck.Pop();
                    }
                    else if (currentData[0] == 3 && stck.Count() > 0)
                    {
                        Console.WriteLine(stck.Max());
                    }
                    else if (currentData[0] == 4 && stck.Count() > 0)
                    {
                        Console.WriteLine(stck.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ",stck));
        }
    }
}
