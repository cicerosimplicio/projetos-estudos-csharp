namespace EmployeeApp.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public double Payment()
        {
            return ValuePerHour * Hours;
        }
    }
}
