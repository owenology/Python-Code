using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== MAGIC BATTLE ===");
        Console.WriteLine("You are a wizard, you must now defeat the enemy mage before they defeat you!\n");

        bool playAgain = true;

        while (playAgain)
        {
            PlayGame();

            Console.Write("\nDo you want to play again? (y/n): ");
            string answer = Console.ReadLine().ToLower();

            if (answer != "y")
            {
                playAgain = false;
            }

            Console.Clear();
        }

        Console.WriteLine("Thanks for playing!");
    }

    static void PlayGame()
    {
        Random rnd = new Random();
        int playerHP = 50;
        int enemyHP = 50;
        string[] spells = { "fire", "ice", "lightning" };

        while (playerHP > 0 && enemyHP > 0)
        {
            Console.WriteLine($"\nYour HP: {playerHP} | Enemy HP: {enemyHP}");
            Console.WriteLine("Choose your spell: fire / ice / lightning");
            Console.Write("Your move: ");
            string playerSpell = Console.ReadLine().ToLower();

            if (playerSpell != "fire" && playerSpell != "ice" && playerSpell != "lightning")
            {
                Console.WriteLine("You fumbled your spell and lost your turn!");
                playerSpell = "none";
            }

            string enemySpell = spells[rnd.Next(spells.Length)];
            Console.WriteLine($"Enemy casts {enemySpell}!");

            int playerDamage = rnd.Next(5, 16);
            int enemyDamage = rnd.Next(5, 16);

            // Spell interactions
            if (playerSpell == "fire" && enemySpell == "ice")
            {
                enemyDamage = 0;
                Console.WriteLine("Your fire melts the enemy's ice! Double damage!");
                enemyHP -= playerDamage * 2;
            }
            else if (playerSpell == "ice" && enemySpell == "lightning")
            {
                enemyDamage = 0;
                Console.WriteLine("Your ice blocks the lightning! Double damage!");
                enemyHP -= playerDamage * 2;
            }
            else if (playerSpell == "lightning" && enemySpell == "fire")
            {
                enemyDamage = 0;
                Console.WriteLine("Your lightning overpowers the fire! Double damage!");
                enemyHP -= playerDamage * 2;
            }
            else
            {
                enemyHP -= playerDamage;
                playerHP -= enemyDamage;
                Console.WriteLine($"You dealt {playerDamage} damage.");
                Console.WriteLine($"Enemy dealt {enemyDamage} damage.");
            }

            if (playerHP <= 0 || enemyHP <= 0)
            {
                break;
            }
        }

        Console.WriteLine("\n=== Battle Over ===");
        if (playerHP <= 0 && enemyHP <= 0)
        {
            Console.WriteLine("It's a draw! Both mages collapse!");
        }
        else if (playerHP <= 0)
        {
            Console.WriteLine("You were defeated...");
        }
        else
        {
            Console.WriteLine("You win! The enemy mage is defeated!");
        }
    }
}
