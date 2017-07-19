using System;

namespace AnimalClasses.Animals 
{
    public class Squirrel : Animal, IFurryAnimal, IWalkingAnimal

    {
        public new int NumberOfLegs => 4;
        public string TypeOfFur {get; set;}

        public int TailLength {get; set;}

        public Squirrel(string name, string typeOfFur)
        {
            Name = name;
            TypeOfFur = typeOfFur;
        }

        public void Walk(int paceCount)
        {
            for (int i = 0; i < paceCount; i++)
            {

                var typeOfStep = "";
                var direction = "";
                if (i % 2 == 0)
                {
                    typeOfStep = "Scampered";
                    direction = "left";
                }
                else 
                {
                    typeOfStep = "Scurried";
                    direction = "right";
                }
                Console.WriteLine($"{Name} the squirrel {typeOfStep} {direction}");
            }
        }
    }

}