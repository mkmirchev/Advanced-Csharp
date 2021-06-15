using System;
using System.IO;
using System.Linq;

namespace Lane_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allLines = File.ReadAllLines(path: "./text.txt");
            for (int i = 0; i < allLines.Length; i++)
            {
                string currentLine = allLines[i];
                int currentLetters = CharCounter(currentLine);
                int currentPunctionalMarks = MarksCounter(currentLine);
                allLines[i] = $"Line {i + 1}: {currentLine} ({currentLetters})({currentPunctionalMarks})";
            }
            File.WriteAllLines(path: "../../../output.txt", allLines);
        }
        static int CharCounter(string line)
        {
            int output = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsLetter(line[i]))
                {
                    output++;
                }
            }
            return output;
        }
        static int MarksCounter(string line)
        {
            char[] marks = {'.', '-', ',', '?','!' };
            int output = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (marks.Contains(line[i]))
                {
                    output++;
                }
            }
            return output;
        }
    }
}
