// I decided to make a more advanced version of the Guess the number game, and as a refresher for coding within C# for myself.

using System;

class GuessTheNumberGame
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Guess the Number Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100.");

        PlayGame();  // start the game

        Console.WriteLine("Thanks for playing!");
    }

    static void PlayGame()
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int userGuess = 0;
        int attempts = 0;

        while (userGuess != magicNumber)
        {
            userGuess = GetUserGuess();
            attempts++;
            string result = CheckGuess(userGuess, magicNumber);
            Console.WriteLine(result);
        }

        Console.WriteLine($"\nYou guessed the number in {attempts} attempts!");
    }

    static int GetUserGuess()
    {
        int guess;
        while (true)
        {
            Console.Write("\nEnter your guess: ");
            if (int.TryParse(Console.ReadLine(), out guess) && guess >= 1 && guess <= 100)
            {
                return guess;
            }
            Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
        }
    }

    static string CheckGuess(int guess, int target)
    {
        if (guess < target)
        {
            return "Too low! Try again.";
        }
        else if (guess > target)
        {
            return "Too high! Try again.";
        }
        else
        {
            return "Correct! You found the magic number!";
        }
    }
}
