using System.Globalization;
namespace ExFuncionario
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        //CONSTRUCTOR
        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

        // METHODS
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return ID
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
