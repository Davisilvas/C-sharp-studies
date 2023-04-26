using System;
using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Davi", 500.00);
            Account acc2 = new SavingsAccount(2001, "Maria", 500.00, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine("Conta comum: " + acc1.Balance);
            Console.WriteLine("Conta poupança: " + acc2.Balance);
        }
    }
}