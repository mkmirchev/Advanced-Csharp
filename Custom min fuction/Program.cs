using System;
using System.Collections.Generic;
using System.Linq;
namespace Custom_min_fuction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> customFunc = minValue;
            int minValue(List<int> lst)
            {
                return lst.Min();
            }
            Console.WriteLine(customFunc(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()));
        }
    }
}
