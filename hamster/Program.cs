using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamster
{

    class Program
    {
        static void Main(string[] args)
        {
            Hamster ripl = new Hamster();
            ripl.name = "Ripley";
            ripl.weight = 0.1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"ROUND {i + 1}");

                ripl.Eat();

                if (ripl.weight >= 0.7)
                {
                    for (double y = ripl.weight; y > 0.7; y -=0.1)
                    {
                        ripl.Exercise();
                    }
                }
                
                ripl.lifespan++;
                ripl.age++;
                ripl.PrintAnimalBaseInfo();

            }
            Console.WriteLine($"Hamster {ripl.name} died at age of {ripl.age}");
            Console.ReadLine();
        }
    }
}
