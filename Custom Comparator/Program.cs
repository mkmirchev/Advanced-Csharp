using System;
using System.Linq;
namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int, int, int> customComp = (int numOne, int numTwo) =>
              (numOne % 2 == 0 && numTwo % 2 != 0) ? -1 :
              (numOne % 2 != 0 && numTwo % 2 == 0) ? 1 :
              numOne.CompareTo(numTwo);
            Array.Sort<int>(arr, new Comparison<int>(customComp));
            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
