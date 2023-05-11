using System;

namespace LPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\MY_DESKTOP\1 CODES\c_CSharpe\section_13\LDirectory\LessonFile\file1.txt";

            Console.WriteLine("GetDirectoryName");
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine();


            Console.WriteLine("DirectorySeparatorChar");
            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine();

            Console.WriteLine("PathSeparator");
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine();

            Console.WriteLine("GetFileName");
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine();

            Console.WriteLine("GetFileNameWithoutExtension");
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine();

            Console.WriteLine("GetExtension");
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine();

            Console.WriteLine("GetFullPath");
            Console.WriteLine(Path.GetFullPath(path));
            Console.WriteLine();

            Console.WriteLine("GetTempPath");
            Console.WriteLine(Path.GetTempPath());
            Console.WriteLine();
        }
    }
}