namespace PetsInClass;

public class Dog:Pet
{
    public Dog(string name) 
        : base(name)
    {
        noise = "bark";
        trick = "be loyal";
    }
}