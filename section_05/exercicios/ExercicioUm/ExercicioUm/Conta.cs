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
        private double _bankDeposit;
        public double BankBalance { get; private set; }

        // CONSTRUCTORS
        public Conta(string name, int accountNumber)
        {
            _name = name;
            _accountNumber = accountNumber;
        }

        public Conta(string name, int accountNumber, double bankDeposit) : this(name, accountNumber)
        {
            _bankDeposit = bankDeposit;

            Deposit(bankDeposit);
        }




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
                    Console.WriteLine("O nome não pode ser vazio e deve conter no mínimo 3 caracteres.");
                }
            }
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
            private set
            {
                if (value < 1000)
                {
                    Console.WriteLine("O Número da conta deve conter 4 dígito e não pode começar com 0.");
                }
                else
                {
                    _accountNumber = value;
                }
            }
        }

        public double BankDeposit
        {
            get { return _bankDeposit; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("O depósito inicial deve ser maior que R$0.");
                }
                else
                {
                    _bankDeposit = value;
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
                Console.WriteLine("O Valor de um depósito deve ser maior do que 0.");
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
            }
        }

        public override string ToString()
        {
            return "Conta: " + _accountNumber
                + ", Titular da conta: " + _name
                + ", Saldo total: " + BankBalance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
