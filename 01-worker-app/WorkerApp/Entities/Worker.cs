using WorkerApp.Entities.Enums;

namespace WorkerApp.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        pu

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = departament;
        }

        public void AddContract(Contracts contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(Contracts contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (Contracts contract in Contracts)
            {
                if (year == contract.Year && month == contract.Month)
                {
                    sum += contract.TotalValue
                }
            }
           
            return sum;
        }
    }
}