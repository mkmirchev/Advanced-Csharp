using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            string input = "";
            for (int i = 0; i < a; i++)
            {
                input = Console.ReadLine();
                if (!names.Contains(input))
                {
                    names.Add(input);
                }
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
