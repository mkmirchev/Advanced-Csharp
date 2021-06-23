using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.47;
            double sum = 1000;
            for (int i = 0; i < 365; i++)
            {
                int b = (int)Math.Round(sum/1000,0);
                a *= b;
                sum += a * 23;
            }
            Console.WriteLine(sum);
        }
    }
}
