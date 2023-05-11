using System;
using System.IO;

namespace LStreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\MY_DESKTOP\RemediosDoly.txt";
            string targetPath = @"D:\MY_DESKTOP\file2.txt";
            
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
