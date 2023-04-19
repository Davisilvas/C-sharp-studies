using System.Globalization;
using System;

namespace ExFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> staff = new List<Employee>();

            for (int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                staff.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int increaseID = int.Parse(Console.ReadLine());

            Employee employeeId = staff.Find(x => x.ID == increaseID);

            if (employeeId != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employeeId.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees");
            foreach (Employee employee in staff)
            {
                Console.WriteLine(employee);
            }






        }
    }
}
