using System;

namespace RefAndOut 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a); // ref exige que a variável seja iniciada.
            Console.WriteLine(a);

            // using OUT
            // out não exige que a variável esteja iniciada, apenas declarada.
            int b = 20;
            int triple;
            Calculator.Ttriple(b, out triple);
            Console.WriteLine(triple);

            // ambos são considerados code smells
        }
    }
}