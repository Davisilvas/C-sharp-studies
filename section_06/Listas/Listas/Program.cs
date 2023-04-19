using System;
using System.Collections.Concurrent;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Davi");
            list.Add("Maria");
            list.Add("Doly");
            list.Add("Nina");
            list.Insert(1, "Thor");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);
            Console.WriteLine("**************************");
            string s1 = list.Find(x => x[0] == 'M');
            Console.WriteLine("First 'M': " + s1);

            Console.WriteLine("**************************");
            string s2 = list.FindLast(x => x[0] == 'D');
            Console.WriteLine("Last 'D': " + s2);

            Console.WriteLine("**************************");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string name in list2)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("**************************");
            list.RemoveRange(2, 2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}