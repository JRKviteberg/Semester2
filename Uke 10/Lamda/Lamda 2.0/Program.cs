namespace Lamda_2._0;

class Program
{
    delegate void PrintMethod(string text);
    
    
    static void Main(string[] args)
    {
        PrintMethod chosenOne = (text) => Console.WriteLine(text);

        Action<string> thingToDo = (string text) => Console.WriteLine(text);
        
        Action BigAction = () =>
        {
            Console.WriteLine("ehllo,");
            Console.WriteLine("I do stuff");
            
            chosenOne.Invoke("Look at me");
        }
        Console.WriteLine("Hello, World!");
    };
    
    BigAction.Invoke();
    
    static void Print
}