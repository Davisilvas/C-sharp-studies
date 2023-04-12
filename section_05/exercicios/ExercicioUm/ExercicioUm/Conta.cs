using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;

namespace ExercicioUm
{
    internal class Conta
    {
        private int _accountNumber;
        private string _name;               
        public double BankBalance { get; private set; }

        // CONSTRUCTORS
        public Conta(string name, int accountNumber)
        {
            Name = name;
            AccountNumber = accountNumber;
        }

        public Conta(string name, int accountNumber, double bankDeposit) : this(name, accountNumber)
        {
            if(bankDeposit > 0)
            {
                Deposit(bankDeposit);            
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("O depósito inicial deve ser maior que R$0.");
                Console.Write("Insira o depósito na formatação correta: ");
                bankDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Deposit(bankDeposit);
            }
            
        }


        // PROPERTIES
        public string Name
        {
            get { return _name; }

            set
            {
                if (value != null && value.Length >= 3)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("O nome não pode ser vazio e deve conter no mínimo 3 caracteres.");
                    Console.Write("Insira o nome na formatação correta: ");
                    _name = Console.ReadLine();
                }
            }
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
            private set
            {
                if (value < 1000 || value > 10000)
                {
                    Console.WriteLine();
                    Console.WriteLine("O Número da conta deve conter 4 dígitos e não pode começar com 0.");
                    Console.Write("Insira o número na formatação correta: ");
                    _accountNumber = int.Parse(Console.ReadLine());
                }
                else
                {
                    _accountNumber = value;
                }
            }
        }

        // METHODS
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                BankBalance += amount;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("O Valor de um depósito deve ser maior do que 0.");
                Console.Write("Insira um depósito na formatação correta: ");
                amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                BankBalance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                BankBalance -= 5;
                BankBalance -= amount;
            }
            else
            {
                Console.WriteLine("O Valor de um saque deve ser maior do que 0.");
                Console.WriteLine();
                Console.Write("Insira um saque na formatação correta: ");
                amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                BankBalance -= 5;
                BankBalance -= amount;
            }
        }

        public override string ToString()
        {
            return "Conta: " + AccountNumber
                + ", Titular da conta: " + Name
                + ", Saldo total: " + BankBalance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
