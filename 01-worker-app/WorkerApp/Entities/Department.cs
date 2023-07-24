namespace WorkerApp.Entities
{
    internal class Department //aqui foi onde forcei o conflito
    {
        public string Name { get; set; }

        public Department()
        {
            //aqui foi onde forcei o conflito
        }

        public Department(string name)
        {
            Name = name;
        }

        //aqui foi onde forcei o conflito
    }
}
