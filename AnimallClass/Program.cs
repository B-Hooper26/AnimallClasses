namespace AnimallClass
{
    internal class program
    {
        static void Main(string[] args)
        {
            //instantiation
            //Animal One
            Animal Animal1 = new Animal("Sheep","White", 5f, "Male");
            //Animal Two
            Animal Animal2 = new Animal("Cat", "Oranage", 0.5f, "Female");
            //Animal Three
            Animal Animal3 = new Animal("Shark", "Grey/White", 30f, "Male");
            //Animal Four
            Animal Animal4 = new Animal("Kangaroo", "Brown", 8.23f, "Male");

            List<Animal> animals = new List<Animal>() { Animal1, Animal2, Animal3 };

            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }
    }
}