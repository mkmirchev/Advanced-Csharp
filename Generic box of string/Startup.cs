using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class Startup
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            List<string> lst = new List<string>();
            for (int i = 0; i < rows; i++)
            {
                lst.Add(Console.ReadLine());
            }
            Box<string> bList = new Box<string>(lst);
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bList.Swap(lst, indexes[0], indexes[1]);
            Console.WriteLine(bList);
        }
    }
}
