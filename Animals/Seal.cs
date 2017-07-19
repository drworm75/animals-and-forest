namespace AnimalClasses.Animals 
{
    public class Seal : Animal, IFurryAnimal

    {
        public int NumberOfFlipper => 4;
        public string TypeOfFur => "Waterproof";


        public Seal(string name)
        {
            Name = name;

        }
    }

}