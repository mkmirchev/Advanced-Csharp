using System;
using System.Linq;
using System.Collections.Generic;

namespace Reverse_and_exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> isDivisible = IsDivisible;
            bool IsDivisible(int a, int b)
            {
                if (a % b == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            List<int> lst = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int divider = int.Parse(Console.ReadLine());
            List<int> output = new List<int>();
            foreach (int item in lst)
            {
                if (isDivisible(item,divider))
                {
                    output.Add(item);
                }
            }
            output.Reverse();
            Console.WriteLine(string.Join(' ',output));
        }
    }
}
