using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_table
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (var item in input)
                {
                    if (!elements.Contains(item))
                    {
                        elements.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(' ', elements));
        }
    }
}
