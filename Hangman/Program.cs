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
        words.Add("archaebacteria");
        /*words.Add("cataclysmic");
        words.Add("liposuction");
        words.Add("extravaganza");
        words.Add("population");
        words.Add("Tomorrow");
        words.Add("optimization");
        words.Add("calibration");
        words.Add("aptitude");
        words.Add("conceited");
        */
        
        int numberOfListItems = words.Count;
        
        //Console.WriteLine(NumberOfListItems);
        Random rand = new();
        int guessListInteger = rand.Next(0, numberOfListItems);
        string word = words[guessListInteger];
        word = word.ToUpper();
        
        int numberOfGuesses = 0;
        int wrongGuesses = 0;
        
        string guessesString = String.Concat(Enumerable.Repeat("_", word.Length));
        Console.WriteLine(guessesString);
        
        while (numberOfGuesses <= NUMBEROFGUESSES & wrongGuesses < MAXWRONGGUESSES)
        {
            Console.WriteLine("Guess a letter:");
            string guess = Console.ReadLine();

            List<int> charIndex = [];
            int startAt = 0;
            int charLocation = 0;
            int charCount = 0;

            //identify if the guessed character is part of the word and where it is located 
            while (charLocation != -1)
            {
                charLocation = word.IndexOf(guess, startAt);
                if (charCount == 0 & charLocation == -1)
                {
                    wrongGuesses++;
                    break;
                }
                charIndex.Add(charLocation);
                startAt = charLocation + 1;
                charCount++;
            }
            // insert guessed char at indexes provided
            
            
            
           // guess.ToCharArray()


        }
        
        //string x = ["_"] * NumberOfListItems; 
        
        //List<string> hangmanWord = new List<string>();
        Console.WriteLine($"Guessed word: {word}");
        
        Console.WriteLine($"The word is : {word} and guess integer is: {guessListInteger}");

        Console.WriteLine(word.IndexOf('O'));




    }
}