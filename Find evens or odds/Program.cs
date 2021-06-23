using System;
using System.Linq;
using System.Collections.Generic;

namespace Find_evens_or_odds
{
    class Program
    {
        public delegate int[] numbersInRange(int a, int b);
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string set = Console.ReadLine();
            Predicate<int> predicate = set == "odd" 
                ? number => number % 2 != 0 
                : new Predicate<int>(number => number % 2 == 0);
            List<int> result = new List<int>();
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(' ',result));
        }
    }
}
