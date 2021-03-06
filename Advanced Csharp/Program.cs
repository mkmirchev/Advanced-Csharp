using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primalData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int lenght = primalData[0];
            int remove = primalData[1];
            int num = primalData[2];
            int[] values = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stck = new Stack<int>();
            foreach (var item in values)
            {
                stck.Push(item);
            }
            for (int i = 0; i < remove; i++)
            {
                stck.Pop();
            }
            if (stck.Contains(num))
            {
                Console.WriteLine("true");
            }
            else if(stck.Count > 0)
            {
                Console.WriteLine(stck.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
