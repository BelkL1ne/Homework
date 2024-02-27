namespace Homework8
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

    abstract class Animal
    {
        public abstract string Name { get; set; }

        public abstract void GetName();

        public abstract string SetName();

        public abstract void Eat();
        
    }
    class Dog : Animal
    {
        string? name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public override void Eat()
        {
            Console.WriteLine ($"{name} eat.");
        }
        public override void GetName()
        {
            Console.WriteLine(name);
        }

        public override string SetName()
        {
            Console.WriteLine("Name a Dog");
            name = Console.ReadLine();
            return name;
        }
    }
}
