using System;

namespace hamster
{
    class Animal
    {
        public string name;
        public int age = 0;
        public double weight;
        public int lifespan = 0;
        public void PrintAnimalBaseInfo()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Lifespan: {lifespan}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n");
        }

        public void ShowWeight()
        {
            Console.WriteLine($"{name} Weights {weight}");
        }
        public void ShowLifespan()
        {
            Console.WriteLine($"{name} Lifespan: {lifespan}");
        }
        public void Eat()
        {
            weight += 0.2;
            Console.WriteLine("\n");
            Console.WriteLine($"Hamster {name} eats apples and gains +0.2 kg. {name} weights now {weight} kg");
        }
        public void Exercise()
        {
            weight -= 0.1;
            Console.WriteLine($"{name} runs 10M and loses 0.1kg");
        }

    }
}
