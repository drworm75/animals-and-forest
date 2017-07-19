using System;
using System.Collections.Generic;
using AnimalClasses.Animals;

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
                if (animal is IFurryAnimal)
                {
                    Console.WriteLine($"{animal.Name} lives in the {Name} forest in {Location}" +
                                        $" {((IFurryAnimal)animal).TypeOfFur}!");
                }
                else {


                    Console.WriteLine($"{animal.Name} lives in the {Name} forest in {Location}");
                }
                var walkingAnimal = animal as IWalkingAnimal;
                if (walkingAnimal != null) 
                {
                    walkingAnimal.Walk(7);
                }
            }
        }

    }




}