using System;
using System.Globalization;
using EmployeeManagement.Entities;

namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> staff = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int employeeQtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= employeeQtd; i++)
            {
                Console.WriteLine($"Employee #{i} data:");

                Console.Write("Outsourced (y/n): ");
                char outsourced = char.Parse(Console.ReadLine());

                if (outsourced == 'n' || outsourced == 'N')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    staff.Add(new Employee(name, hours, valuePerHour));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    staff.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                    Console.WriteLine();
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in staff)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}