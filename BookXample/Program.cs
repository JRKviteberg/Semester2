namespace BookXample;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Hello, World");
        
        Book myBook1 = new Book("The Fellowship of the Ring");
        myBook1.NumbersOfPages = 5000;
        
        
        
        
        Console.WriteLine(myBook1.Read(pageNumber:3));
        Console.WriteLine("Title: " + myBook1.Title);


        Book emptyBook = new Book("");

    }
}
