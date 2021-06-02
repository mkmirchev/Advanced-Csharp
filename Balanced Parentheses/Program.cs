using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int lnt = input.Length;
            bool isEqual = true;
            Stack<char> stkOne = new Stack<char>();
            Stack<char> stkTwo = new Stack<char>();
            for (int i = 0; i < input.Length/2; i++)
            {
                {
                    stkOne.Push(input[i]);
                }
            }
            
            for (int i = input.Length-1; i >= input.Length / 2; i--)
            {
                {
                    stkTwo.Push(input[i]);
                }
            }
            for (int i = 0; i < stkOne.Count(); i++)
            {
                if (stkOne.Peek() == '[' && stkTwo.Peek() == ']' 
                    || stkOne.Peek() == '{' && stkTwo.Peek() == '}' 
                    || stkOne.Peek() == '(' && stkTwo.Peek() == ')')
                {
                    stkOne.Pop();
                    stkTwo.Pop();
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }
            if (isEqual == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}
