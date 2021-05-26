using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primalData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int lenght = primalData[0];
            int remove = primalData[1];
            int num = primalData[2];
            int[] values = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> qry = new Queue<int>();
            foreach (var item in values)
            {
                qry.Enqueue(item);
            }
            for (int i = 0; i < remove; i++)
            {
                qry.Dequeue();
            }
            if (qry.Contains(num))
            {
                Console.WriteLine("true");
            }
            else if (qry.Count > 0)
            {
                Console.WriteLine(qry.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
