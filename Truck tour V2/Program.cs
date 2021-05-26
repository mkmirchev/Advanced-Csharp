using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_tour_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int readings = int.Parse(Console.ReadLine());
            Queue<int> tourOne = new Queue<int>();
            for (int i = 0; i < readings; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                tourOne.Enqueue(input[0]);
                tourOne.Enqueue(input[1]);
            }
            int additionalFuel = 0;
            int count = 0;
            int innerCount = 0;
            bool stop = false;
            int lenght = tourOne.Count();
            while (stop == false)
            {
                Queue<int> tourTwo = new Queue<int>();
                foreach (var item in tourOne)
                {
                    tourTwo.Enqueue(item);
                }
                while (true)
                {
                    int temp = Rotate(tourTwo);
                    if (additionalFuel + temp < 0)
                    {
                        additionalFuel = 0;
                        innerCount = 0;
                        break;
                    }
                    else
                    {
                        additionalFuel += temp;
                        innerCount++;
                    }
                    if (innerCount == tourOne.Count()/2)
                    {
                        stop = true;
                        break;
                    }
                }
                if (stop == true)
                {
                    break;
                }
                count++;
                tourTwo.Clear();
                for (int i = 0; i < 2; i++)
                {
                    int tmp = tourOne.Dequeue();
                    tourOne.Enqueue(tmp);
                }                
            }
            Console.WriteLine(count);
                  
        }
        private static int Rotate(Queue<int> test)
        {
            int tempOne = test.Dequeue();
            int tempTwo = test.Dequeue();
            int calc = tempOne - tempTwo;
            return calc;
        }
    }
}
