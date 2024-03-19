using System.Runtime.InteropServices;

namespace Generics1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<string> names = new List<string>();
        names.Add("steeeve");
        names.Add("Alex");
        names.Add("Graic");
        names.Add("Adam");
        names.Add("Eve");
        
        List<int> grades = new List<int>();
        grades.Add(42);
        grades.Add(11);
        grades.Add(17);
        grades.Add(99);
        grades.Add(35);
        
        
        
        grades.Sort();
    }


    static void print<t>(List<t> list)
    {
        foreach (T item in list)
        {
            
        }
    }
}


