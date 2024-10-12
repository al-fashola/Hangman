namespace Hangman;

class Program
{
    static void Main(string[] args)
    {
        const int MAX_NUMBER_OF_GUESSES = 15;
        const int MAXWRONGGUESSES = 3;
        
        //intro message
        Console.WriteLine($"Hello, Today we will be playing Hangman! you will have {MAXWRONGGUESSES} strikes and {MAX_NUMBER_OF_GUESSES} total guesses!");
        
        List<string> words = new List<string>();
        words.Add("baby");
        words.Add("cataclysmic");
        words.Add("archaebacteria");
        words.Add("liposuction");
        words.Add("extravaganza");
        words.Add("population");
        words.Add("Tomorrow");
        words.Add("optimization");
        words.Add("calibration");
        words.Add("aptitude");
        words.Add("conceited");
        
        
        int numberOfListItems = words.Count;
        
        //Console.WriteLine(NumberOfListItems);
        Random rand = new();
        int randomListSelection = rand.Next(0, numberOfListItems);
        string word = words[randomListSelection];
        word = word.ToUpper();
        
        int numberOfGuesses = 0;
        int wrongGuesses = 0;
        
        //present the number of characters in the hangman word and split into individual characters as an array 
        char[] guessesList = String.Concat(Enumerable.Repeat("_", word.Length)).ToCharArray();
        Console.WriteLine(guessesList);
     
        
        while (numberOfGuesses <= MAX_NUMBER_OF_GUESSES & wrongGuesses < MAXWRONGGUESSES )
        {
            string final = string.Join("", guessesList);
            if (final == word)
            {
                Console.WriteLine("You Win!");
                Environment.Exit(0);
                //break;
            }
            
            Console.WriteLine("Guess a letter: ");
            char guess = Console.ReadKey().KeyChar;
            char.ToUpper(guess);
          
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
                if (charLocation != -1)
                {
                    //charIndex.Add(charLocation);
                    guessesList[charLocation] = guess;
                    startAt = charLocation + 1;
                    charCount++;
                    // Notes: i could technically input the correct guessed strings into guessesList here
                }
            }

            numberOfGuesses++;
            Console.Clear();
            Console.WriteLine(guessesList);
            Console.WriteLine($"Number of guesses: {numberOfGuesses}, wrong guesses: {wrongGuesses}");


        }
        
        Console.WriteLine("You Lose! ");
        Console.WriteLine($"The word: {word}");
        //Console.WriteLine($"The word is : {word} and guess integer is: {randomListSelection}");




    }
}