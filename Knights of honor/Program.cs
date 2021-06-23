using System;
using System.Linq;

namespace Knights_of_honor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList()
            .ForEach(w => Console.WriteLine("Sir " + w));
        }
    }
}
