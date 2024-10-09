namespace Hangman;

class Program
{
    static void Main(string[] args)
    {
        //intro message
        Console.WriteLine("Hello, Today we will be playing Hangman!");
        
        // Populate list with random words ( look into word generator like name generator exists e.g test data)
        const int NUMBEROFGUESSES = 10;
        List<string> words = new List<string>();
        words.Add("Tom");
        words.Add("populate");
        words.Add("population");
        words.Add("Tom");
        words.Add("Tom");
        words.Add("Tom");
        words.Add("Tom");
        
        int NumberOfListItems = words.Count;
        
        Console.WriteLine(NumberOfListItems);
        Random rand = new();
        rand.Next(0, NumberOfListItems);
        
        
        
        
        
    }
}