//trying out some classes, copnstructors and namespaces in C#

//creation and initilisation of new user defined object

public class Program
{
    static int Main()
    {
        Nature.Plants umbrellaPlant = new("Schefflera");
        Nature.Plants cheesePlant = new("corlionios");

        Console.WriteLine(cheesePlant.GetSpecies());

        Nature.Insects beetle = new("Attagenus","Black", umbrellaPlant);

        Console.WriteLine(beetle.GetSpecies());
        Console.WriteLine(beetle.GetColour());
        Console.WriteLine(beetle.GetFood());

        Console.WriteLine("Main");
        return 0;
    }

}


namespace Nature
{
    public class Plants
    {
        private readonly string species;
        private int nextWater;
        private int waterFrequency;

        public Plants(string name, int waterFreq = 10)
        {
            species = name;
            nextWater = 0;
            waterFrequency = waterFreq;
        }
        public string GetSpecies() { return species; }

        public  void SetWaterFreq(int freq) {  waterFrequency = freq;  }

        public void WaterPlant() {  nextWater = waterFrequency; }

        public void PassDay() { nextWater -= 1; }

    }

    public class Insects
    {
        private readonly string species;
        private readonly string colour;
        private Plants favouriteFood;
        private struct Mass { public int weight, length; }
        public Insects(string name, string colour, Plants food)
        {
            species = name;
            this.colour = colour;
            this.favouriteFood = food;
        }
        public string GetSpecies() { return species; }

        public string GetColour() { return colour; }

        public void SetFood(Plants obj) { favouriteFood = obj; }

        public string GetFood() { return favouriteFood.GetSpecies(); }

        public void SetMass(int w, int l)
        {
            Mass m1 = new();
            m1.length = l;
            m1.weight = w;
        }
    }
}

