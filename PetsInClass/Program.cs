namespace PetsInClass;

class Program
{
    static void Main(string[] args)
    {
        List<Pet> myPets = []; // new List<Pet>();

        //Cat myCat1 = new Cat("Fluffykins");
        //Cat myCat2 = new Cat("Bob");
        
        myPets.Add(new Cat("Fluffykins"));
        myPets.Add(new Cat("Bob"));
        
        myPets.Add(new Dog("Steeve"));
        myPets.Add(new Dog("Max"));
        
        myPets.Add(new Fish("Bubbles"));
        myPets.Add(new Fish("Illidan"));

        foreach (Pet pet in myPets)
        {
            Console.WriteLine($"Pet named {pet.GetName()} " +
                              $"make a {pet.GetNoise()} noise " +
                              $"and can {pet.GetTrick()}.");
        }
        


    }
}