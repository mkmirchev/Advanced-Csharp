using System;
using System.Linq;
using System.Collections.Generic;

namespace Even_times
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Dictionary<int, int> dct = new Dictionary<int, int>();
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (!dct.Keys.Contains(b))
                {
                    dct.Add(b, 1);
                }
                else if(dct.Keys.Contains(b))
                {
                    dct[b] += 1;
                }
            }
            foreach (var item in dct)
            {
                if (item.Value / 2 == 1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
