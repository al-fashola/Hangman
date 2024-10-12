namespace Hangman;

class Program
{
    static void Main(string[] args)
    {
        //intro message
        Console.WriteLine("Hello, Today we will be playing Hangman!");
        
        // Populate list with random words ( look into word generator like name generator exists e.g test data)
        const int NUMBEROFGUESSES = 10;
        const int MAXWRONGGUESSES = 3;
        
        List<string> words = new List<string>();
        words.Add("liposuction");
        words.Add("populate");
        words.Add("population");
        words.Add("Tomorrow");
        words.Add("optimization");
        words.Add("calibration");
        words.Add("aptitude");
        words.Add("conceited");
        
        int numberOfListItems = words.Count;
        
        //Console.WriteLine(NumberOfListItems);
        Random rand = new();
        int guessListInteger = rand.Next(0, numberOfListItems);
        string word = words[guessListInteger];
        word = word.ToUpper();
        
        int numberOfGuesses = 0;
        int wrongGuesses = 0;
        
        
/*
        while (numberOfGuesses <= NUMBEROFGUESSES & wrongGuesses < MAXWRONGGUESSES)
        {
            Console.WriteLine("Guess a letter:");
            string guess = Console.ReadLine();
            guess.ToCharArray()


        }
        */
        //string x = ["_"] * NumberOfListItems; 
        
        //List<string> hangmanWord = new List<string>();
        Console.WriteLine($"Guessed word: {word}");
        
        Console.WriteLine($"The word is : {word} and guess integer is: {guessListInteger}");

        Console.WriteLine(word.IndexOf('O'));




    }
}