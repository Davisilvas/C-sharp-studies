using System;
using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(2810, "Davi Santos", 100.00, 500.00);
            
            Console.WriteLine(account.Balance);           
        }
    }
}