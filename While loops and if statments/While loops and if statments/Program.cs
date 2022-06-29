using System;
namespace project
{
    public class guessGame
    {
        public static void Main(string[] args)
        {
            string secretWord = "pop";
            string guess = "";
            int attempts = 0;
            int allowed = 3;
            bool outOfGuesses = false;


            while (guess != secretWord && !outOfGuesses)
            {
                if (attempts < allowed)
                {
                    Console.Write("Guess the word : ");
                    guess = Console.ReadLine();
                    attempts++;
                }
                else
                {
                    outOfGuesses = true;
                }

            }
            if (outOfGuesses)
            {
                Console.WriteLine("You loose!!");

            }
            else
            {
                Console.WriteLine("You guessed right");
            }

        }

    }

}