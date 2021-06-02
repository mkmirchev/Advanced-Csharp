using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string input = "";
            Stack<string> log = new Stack<string>();
            log.Push(input);
            for (int i = 0; i < a; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "1")
                {
                    input = log.Peek() + command[1];
                    log.Push(input);
                }
                else if (command[0] == "2")
                {
                    input = log.Peek();
                    input = input.Remove(input.Length - int.Parse(command[1]));
                    log.Push(input);
                   
                }
                else if (command[0] == "3")
                {
                    Console.WriteLine(log.Peek()[int.Parse(command[1])-1]);
                }
                else if (command[0] == "4")
                {
                    log.Pop();
                }
            }
        }
    }
}
