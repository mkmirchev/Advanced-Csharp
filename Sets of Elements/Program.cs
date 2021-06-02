using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] firstSet = new int[sets[0]];
            int[] secondSet = new int[sets[1]];
            List<int> equal = new List<int>();
            for (int i = 0; i < sets[0]; i++)
            {
                firstSet[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < sets[1]; i++)
            {
                secondSet[i] = int.Parse(Console.ReadLine());
            }
            if (secondSet.Length <= firstSet.Length)
            {
                for (int i = 0; i < firstSet.Length; i++)
                {
                    for (int j = 0; j < secondSet.Length; j++)
                    {
                        if (secondSet[j] == firstSet[i] && !equal.Contains(secondSet[j]))
                        {
                            equal.Add(secondSet[j]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondSet.Length; i++)
                {
                    for (int j = 0; j < firstSet.Length; j++)
                    {
                        if (secondSet[j] == firstSet[i] && !equal.Contains(secondSet[j]))
                        {
                            equal.Add(secondSet[j]);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(' ',equal));
        }
    }
}
