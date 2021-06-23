using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Task 1
            //string name = "Pesho";
            //int age = 24;
            //Person pesho = new Person()
            //{
            //    Name = name,
            //    Age = age
            //};
            //Console.WriteLine($"{pesho.Name} - {pesho.Age}");

            //Task 2
            //Person noName = new Person();
            //Person george = new Person(24);
            //Person ivan = new Person("ivan", 27);
            //Console.WriteLine($"{noName.Name} - {noName.Age}");
            //Console.WriteLine($"{george.Name} - {george.Age}");
            //Console.WriteLine($"{ivan.Name} - {ivan.Age}");
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
            Console.WriteLine(family.GetOldestMember());
        }
    }
}
