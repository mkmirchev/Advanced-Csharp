using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader(path: "words.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string word = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray()[0].ToLower();
                    if (!result.ContainsKey(word))
                    {
                        result[word] = 0;
                    }
                    line = reader.ReadLine();
                }
            }
            using (StreamWriter writer = new StreamWriter(path:"../../../result.txt"))
            {
                using (StreamReader reader = new StreamReader(path:"text.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] word = line.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(x =>x.TrimStart(new char[] { '.', '-', ',', '?', '!' }))
                            .Select(x => x.TrimEnd(new char[] { '.', '-', ',', '?', '!' }))
                            .Select(x => x.ToLower())
                            .ToArray();
                        foreach (string wrd in word)
                        {
                            if (result.ContainsKey(wrd))
                            {
                                result[wrd]++; ;
                            }
                        }
                        line = reader.ReadLine();
                    }
                    foreach (KeyValuePair<string,int> kvp in result.OrderByDescending(x=>x.Value))
                    {
                        writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                    }
                }
            }
        }
    }
}
