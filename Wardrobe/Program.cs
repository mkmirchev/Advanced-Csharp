using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();
                string[] clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!wardrobe.Keys.Contains(input[0]))
                {
                    wardrobe.Add(input[0], new Dictionary<string, int>());
                    CheckCloths(wardrobe, input, clothes);

                }
                else
                {
                    CheckCloths(wardrobe, input, clothes);
                }
            }
            string[] find = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in wardrobe)
            {
                Console.WriteLine(item.Key + " clothes:");
                foreach (var cloth in item.Value)
                {
                    if (find[0] == item.Key && find[1] == cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }

        private static void CheckCloths(Dictionary<string, Dictionary<string, int>> wardrobe, string[] input, string[] clothes)
        {
            for (int l = 0; l < clothes.Length; l++)
            {
                if (!wardrobe[input[0]].Keys.Contains(clothes[l]))
                {
                    wardrobe[input[0]].Add(clothes[l], 1);
                }
                else
                {
                    wardrobe[input[0]][clothes[l]] += 1;
                }
            }
        }
    }
}
