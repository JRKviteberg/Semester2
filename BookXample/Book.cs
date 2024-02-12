namespace BookXample;

public class Book
{
    public String Title;
    public String Author;
    public String ISBN;
    public String Publisher;
    public String Edition;
    public int NumbersOfPages;
    
    public Book(String Title)
    {
        if (Title.Length == 0)
        {
            throw new Exception("empty title");
        }
    }
    
/// <summary>
/// Create a Book with a title only
/// </summary>
/// <param name="pageNumber"></param>
/// <returns></returns>


    internal String Read(int pageNumber)
    {
        if (pageNumber <= NumbersOfPages)
        {
            
            return "page not found";
        }
        
        // return the page
        return "See Spot Run.";
    }
}

