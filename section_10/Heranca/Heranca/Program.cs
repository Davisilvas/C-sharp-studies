using System;
using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##############################");
            Console.WriteLine("Inheritance Lesson");

            BusinessAccount account = new BusinessAccount(2810, "Davi Santos", 100.00, 500.00);
            
            Console.WriteLine(account.Balance);

            Console.WriteLine();
            Console.WriteLine("##############################");
            Console.WriteLine("Downcasting & Upcasting Lesson");

            Account acc = new Account(1001, "Doly", 0.0);
            BusinessAccount bAcc = new BusinessAccount(2001, "Maria", 1000.00, 7000.00);

            // UPCASTING
            Account acc1 = bAcc;
            Account acc2 = new BusinessAccount(2002, "Milio", 0.0, 200.00);
            Account acc3 = new SavingsAccount(3001, "Thresh", 120.00, 0.01);

            // DOWNCASTING
            BusinessAccount bAcc2 = (BusinessAccount)acc2;
            bAcc2.Loan(155.00);

            // errado! BusinessAccount bAcc3 = (BusinessAccount)acc3;
            // downcasting é inseguro - usar só quando realmente necessário.

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount bAcc3 = (BusinessAccount)acc3;
                BusinessAccount bAcc3 = acc3 as BusinessAccount;
                bAcc3.Loan(10.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount sAcc1 = (SavingsAccount)acc3;
                sAcc1.UpdateBalance();
                Console.WriteLine("update!");
                Console.WriteLine(sAcc1.Balance);
            }


        }
    }
}