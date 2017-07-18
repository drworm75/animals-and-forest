using System;

namespace AnimalClasses
{
    class Program
    {
        static void Main(string[] args)
        {

        var radnor = new Forest("Radnor Lake", "Nashville");

        var raccoon = new Animal {Name = "Raccoon",  NumberOfLegs = 4, Fur = true};
        var turtle = new Animal {Name = "Turtle",  NumberOfLegs = 4, Fur = false};
        var mockingbird = new Animal {Name = "Mockingbird",  NumberOfLegs = 2, Fur = true};
        var deer = new Animal {Name = "Deer",  NumberOfLegs = 4, Fur = true};
        var frog = new Animal {Name = "Frog",  NumberOfLegs = 4, Fur = false};

        radnor.AddAnimal(turtle);
        radnor.AddAnimal(raccoon);
        radnor.AddAnimal(mockingbird);
        radnor.AddAnimal(deer);
        radnor.AddAnimal(frog);


        radnor.ListAnimals();
            
        }
    }
}
