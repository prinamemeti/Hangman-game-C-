using System;

namespace Hangman_game
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] guessedLetter = new char[26];
            char[] answer = "horse".ToCharArray();
            char guess;
            int score = 0, index = 0;
            Console.WriteLine("********");

            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Enter your guess:");
                guess = char.Parse(Console.ReadLine());

                if (guess == guessedLetter[1] || guess == guessedLetter[2] || guess == guessedLetter[3] || guess == guessedLetter[4] || guess == guessedLetter[5])
                {
                    Console.WriteLine("Your guess is correct.");
                    guessedLetter[index] = guess;
                    index++;
                }
                else
                {
                    Console.WriteLine("Your guess is incorrect.");
                    score++;
                }
            }

        }
    }
}
