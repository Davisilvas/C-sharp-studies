using System;
using System.IO;

namespace LessonOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\MY_DESKTOP\RemediosDoly.txt";
            string targetPah = @"D:\MY_DESKTOP\file1.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPah);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine();
                Console.WriteLine(lines[0]);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}