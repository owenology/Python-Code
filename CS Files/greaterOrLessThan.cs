
// It's hard to access my C# Files from my first year of doing computer science, here is a basic file / code from towards the start of the year.

using System;

Random magic = new Random();
int magicNum = magic.Next(1, 101);

int userGuess = 0;

Console.WriteLine("Enter your guess for a magic number between 1 and 100: ");
userGuess = Convert.ToInt32(Console.ReadLine());

while (userGuess != magicNum)
{
    if (userGuess < magicNum)
    {
        Console.WriteLine("Your guess was less than the magic number.");
    }
    else
    {
        Console.WriteLine("Your guess was greater than the magic number.");
    }

    Console.WriteLine("Enter another guess: ");
    userGuess = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("You did it!");
