using System;

namespace Genereics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var personInfo = Console.ReadLine().Split();
            var fullName = $"{personInfo[0]} {personInfo[1]}";
            var city = $"{personInfo[2]}";
            var nameAndBeer = Console.ReadLine().Split();
            var name = $"{nameAndBeer[0]}";
            var beer = $"{int.Parse(nameAndBeer[1])}";
            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName,city);
            Tuple<string, string> secondTuple = new Tuple<string, string>(name,beer);
            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
        }
    }
}
