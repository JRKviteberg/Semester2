namespace PetsInClass;

public class Pet
{
    protected string name;
    protected string noise;
    protected string trick;

    public Pet(string name)
    {
        this.name = name;
    }


    public string GetName()
    {
        return name;
    }

    public string GetNoise()
    {
        return noise;
    }

    public string GetTrick()
    {
        return trick;
    }
}