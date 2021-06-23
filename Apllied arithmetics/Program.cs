using System;
using System.Linq;

namespace Apllied_arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> add = addValue;
            int[] addValue(int[] inpt)
            {
                for (int i = 0; i < inpt.Length; i++)
                {
                    inpt[i]++;
                }
                return inpt;
            }
            Func<int[], int[]> multiply = multiplyValue;
            int[] multiplyValue(int[] inpt)
            {
                for (int i = 0; i < inpt.Length; i++)
                {
                    inpt[i]*=2;
                }
                return inpt;
            }
            Func<int[], int[]> substract = subtractValue;
            int[] subtractValue(int[] inpt)
            {
                for (int i = 0; i < inpt.Length; i++)
                {
                    inpt[i] -=1;
                }
                return inpt;
            }
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = "";
            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "add")
                {
                   arr = addValue(arr);
                }
                else if (command == "subtract")
                {
                    arr = subtractValue(arr);
                }
                else if (command == "multiply")
                {
                    arr = multiplyValue(arr);
                }
                else if(command == "print")
                {
                    Console.WriteLine(string.Join(' ',arr));
                }
            }
        }
    }
}
