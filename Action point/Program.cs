using System;
using System.Linq;

namespace Action_point
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList()
            .ForEach(w => Console.WriteLine(w));
        }
    }
}
