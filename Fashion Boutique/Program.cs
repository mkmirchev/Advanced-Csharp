using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothsInBox = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> warehouse = new Stack<int>();
            int racks = 1;
            foreach (var item in clothsInBox)
            {
                warehouse.Push(item);
            }
            int currentCapacity = 0;
            while (warehouse.Count()>0)
            {
                int a = warehouse.Peek();
                if (currentCapacity + a > rackCapacity)
                {
                    racks++;
                    currentCapacity = 0;
                }
                else if (currentCapacity + a == rackCapacity)
                {
                    if (warehouse.Count() == 1)
                    {
                        currentCapacity = 0;
                        warehouse.Pop();
                    }
                    else
                    {
                        racks++;
                        currentCapacity = 0;
                        warehouse.Pop();
                    }
                   
                }
                else
                {
                    currentCapacity += a;
                    warehouse.Pop();
                }             
            }
            Console.WriteLine(racks);
        }
    }
}
