using WorkerApp.Entities;
using WorkerApp.Entities.Enums;

namespace WorkerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/Pleno/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = int.Parse(Console.ReadLine());

            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts to this worker? ");
            int totalContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= totalContracts; i++)
            {
                Console.WriteLine($"Enter {i}# contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.Write($"Name: {worker.Name}");
            Console.Write($"Department: {worker.Department.Name}");
            Console.Write($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2")}");
        }
    }
}