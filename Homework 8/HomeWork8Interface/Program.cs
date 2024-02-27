namespace HomeWork8Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog Dog = new Dog();
            Dog.SetName();
            Dog.GetName();
            Dog.Eat();
        }
    }
    interface Animal
    {
        public string Name { get; set; }

        public void GetName();

        public string SetName();

        public void Eat();
    }
    class Dog : Animal
    {
        string? name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public void Eat()
        {
            Console.WriteLine($"{name} eat.");
        }
        public void GetName()
        {
            Console.WriteLine(name);
        }

        public string SetName()
        {
            Console.WriteLine("Name a Dog");
            name = Console.ReadLine();
            return name;
        }
    }
}
