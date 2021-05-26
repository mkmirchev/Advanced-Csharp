using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_food
{
    class Program
    {
        static void Main(string[] args)
        {
            int products = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> ordersQueue = new Queue<int>();
            foreach (int item in orders)
            {
                ordersQueue.Enqueue(item);
            }
            int max = ordersQueue.Max();
            int sum = 0;
            while (true)
            {
                if (ordersQueue.Peek() + sum > products)
                {
                    break;
                }
                int a = ordersQueue.Peek();
                sum += a;
                ordersQueue.Dequeue();
                if (ordersQueue.Count() == 0)
                {
                    break;
                }
           
            }
            Console.WriteLine(max);
            if (ordersQueue.Count() == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: " + string.Join(' ',ordersQueue));
            }
        }
    }
}
