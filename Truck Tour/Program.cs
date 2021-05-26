using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int readings = int.Parse(Console.ReadLine());
            Queue<UInt32> tour = new Queue<UInt32>();
            for (int i = 0; i < readings; i++)
            {
                UInt32[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(UInt32.Parse)
                    .ToArray();
                tour.Enqueue(input[0]);
                tour.Enqueue(input[1]);
            }
            int count = tour.Count();
            UInt32 fuel = 0;
            int indexCount = 0;
            FindSolution(tour,fuel,indexCount,count);
        }

        private static void FindSolution(Queue<UInt32> tour, UInt32 fuel, int indexCount, int count)
        {
            while (true)
            {
                UInt32 petrol = RotateQueueAndPrintValue(tour);
                UInt32 distance = RotateQueueAndPrintValue(tour);
                UInt32 volume = 0;
                if ((UInt64)(fuel+petrol) > 1000000000)
                {
                    volume = 1000000000;
                }
                else
                {
                    volume = fuel + petrol;
                }
                if (volume >= distance && count >= 0)
                {
                    fuel = fuel + petrol - distance;
                    count--;
                }
                else
                {
                    count = tour.Count();
                    fuel = 0;
                    indexCount++;
                    FindSolution(tour, fuel, indexCount, count);
                    break;
                   
                }
                if (count < 0)
                {
                    Console.WriteLine(indexCount);
                    break;
                }
               
            }
        }

        private static UInt32 RotateQueueAndPrintValue(Queue<UInt32> test)
        {
            UInt32 temp = test.Dequeue();
            test.Enqueue(temp);
            return temp;
        }
    } 
}

