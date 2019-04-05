using System;

namespace RecursivePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var pet = new Dog();
            pet.Name = "Belinha";
            pet.Vaccionate = false;

            if (pet is Dog { Vaccionate: false, Name: string name })
            {
                Console.WriteLine($"My dog's name is {name}");
            }
        }
    }
}
