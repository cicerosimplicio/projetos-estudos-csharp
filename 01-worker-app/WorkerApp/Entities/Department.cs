namespace WorkerApp.Entities
{
    internal class Department //teste de conflito
    {
        public string Name { get; set; }

        public Department()
        {
            //teste de conflito
        }

        public Department(string name)
        {
            Name = name;
        }

        //teste de conflito
    }
}
