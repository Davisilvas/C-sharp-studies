using System;

namespace ParamsLesson // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = Calculator.sum(2, 3, 5, 6);
            int x2 = Calculator.sum(2, 3);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}