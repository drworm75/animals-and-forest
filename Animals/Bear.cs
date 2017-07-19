using System;

namespace AnimalClasses.Animals 
{
    public class Bear : Animal, IFurryAnimal

    {
        public new int NumberOfLegs => 2;
        public string TypeOfFur {get; set;}

        public int TailLength {get; set;}

        public int PicnicBasketAmout {get; set;}

        public Bear(string name, string typeOfFur)
        {
            Name = name;
            TypeOfFur = typeOfFur;
        }

    }

}