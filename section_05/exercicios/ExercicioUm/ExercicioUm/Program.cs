using System;
using System.Globalization;

namespace ExercicioUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("****************************************");
            Console.WriteLine("Seja bem vindo ao Banco Vasco da Gama");
            Console.WriteLine("****************************************");

            Conta account;

            Console.WriteLine();
            Console.Write("Entre o número da conta: ");
            int AcNumber = int.Parse(Console.ReadLine()); // AcNumber = AccountNumber

            Console.Write("Entre o titular da conta: ");
            string name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char decision = char.Parse(Console.ReadLine());           


            if (decision == 's' || decision == 'S') 
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double EntryDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account = new Conta(name, AcNumber, EntryDeposit);
            }
            else
            {
                account = new Conta(name, AcNumber);
            }


            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account);
            Console.WriteLine("****************************************");

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(amount);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account);
            Console.WriteLine("****************************************");

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(amount);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account);
            Console.WriteLine("****************************************");

        }
    }
}