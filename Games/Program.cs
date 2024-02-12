using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Games;

class Program
{
    static void Main(string[] args)
    {
        //open a file using Stream Reader
        StreamReader sr = new StreamReader("games.json");
        
        // Handle the file contents using Json Text reader
        JsonTextReader tr = new JsonTextReader(sr);
        
        // Convert tot JObject through JToken
        JObject jo = (JObject)JToken.ReadFrom(tr);

        List<Game> games = JsonConverter<List<Game>>(sr);
        
        /*
        while (!sr.EndOfStream)
        {
            Console.WriteLine(sr.ReadLine()));
        }*/

        Console.ReadKey();

        /*if (File.Exists("games.json"))
        {
            Console.WriteLine("File Exists!");
        }
        else
        {
            Console.WriteLine("No File!");
        }
        */
    }
}