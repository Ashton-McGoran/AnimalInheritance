using System;

namespace AnimalInheritance
{
    
    class Animal
    {
        private string name; 
        protected string type; 
        public string color;  
        public int age;
        public string breed;
        public double height;
        public double weight;

        public void SetName(string name)
        {
            this.name = name;
        }

        public virtual string GetName()
        {
            return this.name;
        }

        public void SetType(string type)
        {
            this.type = type;
        }

        public virtual string GetType()
        {
            return this.type;
        }
    }

    
    class Creatures : Animal
    {
        public bool isFriendly;

        
        public Creatures(string name, string type, string color, int age, string breed, bool isFriendly, double height, double weight)
        {
            SetName(name);
            SetType(type);
            this.color = color;
            this.age = age;
            this.breed = breed;
            this.isFriendly = isFriendly;
            this.height = height;
            this.weight = weight;
        }

        
        public override string GetName()
        {
            return $"Creatures Name: {base.GetName()}";
        }

        public override string GetType()
        {
            return base.GetType();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of animals:");
            int numAnimals = Convert.ToInt32(Console.ReadLine());

            // Array to store animals
            Animal[] animals = new Animal[numAnimals];

            // Input details for each animal
            for (int i = 0; i < numAnimals; i++)
            {
                Console.WriteLine($"\nEnter details for Creature {i + 1}:");

                Console.WriteLine("Enter animal's name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter animal's type:");
                string type = Console.ReadLine();
                Console.WriteLine("Enter animal's color:");
                string color = Console.ReadLine();
                Console.WriteLine("Enter animal's age:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter animal's breed:");
                string breed = Console.ReadLine();
                Console.WriteLine("Enter animal's height:");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter animal's weight:");
                double weight = Convert.ToDouble(Console.ReadLine());

                animals[i] = new Creatures(name, type, color, age, breed, true, height, weight);
            }

            // Display details for each animal
            Console.WriteLine("\nAnimal Details:");
            for (int i = 0; i < numAnimals; i++)
            {
                Console.WriteLine($"\nDetails for Creature {i + 1}:");
                Console.WriteLine($"Name: {animals[i].GetName()}, Type: {animals[i].GetType()}, Color: {animals[i].color}, Age: {animals[i].age}, Breed: {animals[i].breed}, Height: {animals[i].height}, Weight: {animals[i].weight}");
            }
        }
    }
}
