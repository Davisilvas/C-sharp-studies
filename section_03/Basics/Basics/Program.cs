using System;
using System.Globalization;

namespace Basics // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome:");
            string name = Console.ReadLine();

            Console.WriteLine("Informe quantos quartos há na sua casa:");
            int rooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura da sua casa");
            double houseHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Nos informe o seu: último nome, sua idade e sua altura");
            string[] arr = Console.ReadLine().Split();
            string lastName = arr[0];
            int age = int.Parse(arr[1]);
            double userHeight = double.Parse(arr[2]);

            Console.WriteLine("********************");
            Console.WriteLine("Suas entradas foram: ");
            Console.WriteLine(name);
            Console.WriteLine(rooms);
            Console.WriteLine(houseHeight.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(userHeight.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
