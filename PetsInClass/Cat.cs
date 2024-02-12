namespace PetsInClass;

public class Cat:Pet
{
    public Cat(string name)
        : base(name)
    {
        base.noise = "meow";
        base.trick = "dominate the world";
    }
}