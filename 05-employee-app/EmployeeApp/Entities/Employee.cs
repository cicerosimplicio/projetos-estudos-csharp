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

        public double Payment()
        {
            return ValuePerHour * Hours;
        }
    }
}
