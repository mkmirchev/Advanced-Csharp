using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Even_lanes
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader str = new StreamReader("input.txt"))
            {
                int currentLine = 0;
                string line = await str.ReadLineAsync();
                List<string> lst = new List<string>();
                while (line != null)
                {
                    if (currentLine % 2 == 0)
                    {
                        lst.Add(line);
                    }
                    currentLine++;
                    line = await str.ReadLineAsync();
                }
                List<string>[] output = new List<string>[lst.Count];
                for (int i = 0; i < lst.Count; i++)
                {
                    output[i] = lst[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                for (int i = 0; i < output.Count(); i++)
                {
                    for (int j = 0; j < output[i].Count(); j++)
                    {
                        output[i][j] = ModifyWord(output[i][j]);
                    }
                }
                foreach (List<string> row in output)
                {
                    row.Reverse();
                    Console.WriteLine(string.Join(' ', row));
                }
            }           
        }

        public static string ModifyWord(string str)
        {
            string word = str;
            if (str.Contains('-'))
            {
                word = word.Replace('-', '@');
            }
            else if (str.Contains('.'))
            {
               word = word.Replace('.', '@');
            }
            else if (str.Contains(','))
            {
                word = word.Replace(',', '@');
            }
            else if (str.Contains('!'))
            {
                word = word.Replace('!', '@');
            }
            else if (str.Contains('?'))
            {
                word = word.Replace('?', '@');
            }
            return word;
        }
    }
}
