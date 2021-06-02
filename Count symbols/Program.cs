using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            foreach (char ch in input)
            {
                if (!symbols.Keys.Contains(ch))
                {
                    symbols.Add(ch, 1);
                }
                else if (symbols.Keys.Contains(ch))
                {
                    symbols[ch] += 1;
                }
            }
            foreach (var item in symbols)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
