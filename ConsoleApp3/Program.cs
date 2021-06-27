using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double roi = 0.060;
            double amountPerDayCaseOne = 200;
            double amountPerDayCaseTwo = 200;
            for (int i = 1; i < 366; i++)
            {
                amountPerDayCaseOne += roi* amountPerDayCaseOne;
                for (int j = 0; j < 24; j++)
                {
                    amountPerDayCaseTwo += Math.Round(roi / 24,6)* amountPerDayCaseOne;
                }
                if (i == 7 || i == 30 || i == 365)
                {
                    Console.WriteLine($"Amount after {i} days:");
                    Console.WriteLine($"Case One : {Math.Round(amountPerDayCaseOne, 2)}");
                    Console.WriteLine($"Case Two : {Math.Round(amountPerDayCaseTwo, 2)}");
                    Console.WriteLine("---   ---   ---   ---   ---   ---");
                }
            }

        }
    }
}
