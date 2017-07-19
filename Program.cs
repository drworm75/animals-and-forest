using System;
using AnimalClasses.Animals;

namespace AnimalClasses
{
    class Program
    {
        static void Main(string[] args)
        {

        var radnor = new Forest("Radnor Lake", "Nashville");

        var squirrel = new Squirrel ("Squirrel", "Patchy") {TailLength = 4};
        var turtle = new Animal {Name = "Turtle",  NumberOfLegs = 4, Fur = false};
        var mockingbird = new Animal {Name = "Mockingbird",  NumberOfLegs = 2, Fur = true};
        var bear = new Bear ("Yogi", "Blue") {TailLength = 1};
        var seal = new Seal ("Sammie");

        radnor.AddAnimal(turtle);
        radnor.AddAnimal(squirrel);
        radnor.AddAnimal(mockingbird);
        radnor.AddAnimal(bear);
        radnor.AddAnimal(seal);


        radnor.ListAnimals();
            
        }
    }
}
