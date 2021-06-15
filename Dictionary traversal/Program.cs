using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
namespace Dictionary_traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<FileInfo>> fileByExtensions = new Dictionary<string, List<FileInfo>>();
            string path = Console.ReadLine();
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                string extension = info.Extension;
                if (!fileByExtensions.ContainsKey(extension))
                {
                    fileByExtensions[extension] = new List<FileInfo>();
                }
                fileByExtensions[extension].Add(info);
            }
            using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt"))
            {
                foreach (var kvp in fileByExtensions.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
                {
                    writer.WriteLine(kvp.Key);
                    foreach (var fileInfo in kvp.Value.OrderBy(x => Math.Ceiling((double)x.Length / 1024))) 
                    {
                        writer.WriteLine($"--{fileInfo.Name} - {Math.Ceiling((double)fileInfo.Length / 1024)}kb");
                    }
                }
            }
        }
    }
}
