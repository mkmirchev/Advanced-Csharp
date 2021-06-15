using System;
using System.IO.Compression;

namespace Zip_file_and_extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\Users\Axull\Desktop\New folder (2)", @"C:\Users\Axull\Desktop\New folder (3)\testArchive.zip");
            ZipFile.ExtractToDirectory(@"C:\Users\Axull\Desktop\New folder (3)\testArchive.zip", @"C:\Users\Axull\Desktop\New folder (3)");
        }
    }
}
