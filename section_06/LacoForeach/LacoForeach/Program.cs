using System;

namespace LacoForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Davi", "Maria", "Doly" };

            int order = 1;
            foreach (string v in vect)
            {
                Console.WriteLine(order + " - " + v);
                order++;
            }
        }
    }
}
