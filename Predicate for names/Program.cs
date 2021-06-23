using System;
using System.Linq;
using System.Collections.Generic;

namespace Predicate_for_names
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> isLenghtEnough = IsLenghtEnough;
            bool IsLenghtEnough(string s, int a)
            {
                if (s.Length <= a)
                {
                    return true;
                }
                else
                {
                   return false;
                }
            }
            int nameLenght = int.Parse(Console.ReadLine());
            List<string> str = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(x=>isLenghtEnough(x,nameLenght) == true).ToList();
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

        }
    }
}
