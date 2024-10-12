namespace Hangman;

class Program
{
    static void Main(string[] args)
    {
        const int NUMBEROFGUESSES = 10;
        const int MAXWRONGGUESSES = 3;
        
        //intro message
        Console.WriteLine($"Hello, Today we will be playing Hangman! you will have {MAXWRONGGUESSES} strikes");
        
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
        
        //present the number of characters in the hangman word and split into individual characters as an array 
        char[] guessesList = String.Concat(Enumerable.Repeat("_", word.Length)).ToCharArray();
        
        
        //int length = guessesList.Length;
        //Console.WriteLine(length);
        //Console.WriteLine(guessesList);
        
        
        
        while (numberOfGuesses <= NUMBEROFGUESSES & wrongGuesses < MAXWRONGGUESSES)
        {
            Console.WriteLine("Guess a letter: ");
            char guess = Console.ReadKey().KeyChar;
            char.ToUpper(guess);
            //ConsoleKeyInfo guessKey = Console.ReadKey();

            
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
                    charIndex.Add(charLocation);
                    startAt = charLocation + 1;
                    charCount++;
                }
            }
            
            // insert guessed char at indexes provided
            foreach (int val in charIndex)
            {
                guessesList[val] = guess;
            }
            
            Console.Clear();
            Console.WriteLine(guessesList);
            Console.WriteLine($"Number of guesses: {numberOfGuesses}, wrong guesses: {wrongGuesses}");

            
            
           // guess.ToCharArray()


        }
        
        //string x = ["_"] * NumberOfListItems; 
        
        //List<string> hangmanWord = new List<string>();
        Console.WriteLine($"Guessed word: {word}");
        
        Console.WriteLine($"The word is : {word} and guess integer is: {guessListInteger}");

        //Console.WriteLine(word.IndexOf('O'));




    }
}