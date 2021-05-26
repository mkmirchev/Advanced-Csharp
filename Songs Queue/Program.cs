using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> playList = new Queue<string>();
            //reading first playlist
            string[] firstInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            //generating queue
            foreach (var item in firstInput)
            {
                playList.Enqueue(item);
            }
            //Implement commands Play, Add, Show
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Contains("Play"))
                {
                    playList.Dequeue();
                }
                else if (input.Contains("Add"))
                {
                    string newSong = input.Substring(4);
                    if (!playList.Contains(newSong))
                    {
                        playList.Enqueue(newSong);
                    }
                    else
                    {
                        Console.WriteLine(newSong +" is already contained!");
                    }
                }
                else if (input.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",playList));
                }
                if (playList.Count() == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
            }
        }
    }
}
