namespace LetsTrySomething;

class Program
{
    static void Main(string[] args)
    {
        StreamReader sr;
        String output = "nothing appened";

        try
        {
            sr = new StreamReader("data/numbers.txt");
            while (!sr.EndOfStream)
            {
                int num = int.Parse(sr.ReadLine());
                Console.WriteLine(num);
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File not found");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Data Error");
        }
        catch (Exception e)
        {
            Console.WriteLine("An exception occured");
        }
    }
    
}