using System;
using System.IO;
using System.Linq;
namespace Copy_binary_file
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BYTE_BUFF = 4096;
            using (FileStream reader = new FileStream(path: "copyMe.png", FileMode.Open))

            using (FileStream writer = new FileStream(path: "copiedPicture.png", FileMode.Create))
                while (reader.CanRead)
                {
                    byte[] buffer = new byte[BYTE_BUFF];
                    int readBytes = reader.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    writer.Write(buffer, 0, readBytes);
                }
         }
    }
}
