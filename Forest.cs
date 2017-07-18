using System;
using System.Collections.Generic;

namespace AnimalClasses
{
    public class Forest

    {
        public string Name { get; }
        public string Location { get; }
        List<Animal> Animals { get; set; }

        public Forest(string name, string location)

        {
            Name = name;
            Location = location;
            Animals = new List<Animal>();

        }

        public void AddAnimal(Animal newAnimal)

        {
            Animals.Add(newAnimal);
        }

        public void ListAnimals()
        {
            foreach (var animal in Animals)

            {
                Console.WriteLine($"{animal.Name} lives in the {Name} forest.  {animal.Name} has {animal.NumberOfLegs}.  Does it have fur? {animal.Fur}");
            }
        }

    }




}