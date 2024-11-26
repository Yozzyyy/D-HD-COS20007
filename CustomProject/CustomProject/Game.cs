using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public abstract class Game
    {
        public Player Player { get; private set; }

        public Game(Player player)
        {
            Player = player;
        }

        public void Start()
        {
            Console.WriteLine($"Hello {Player.Name} a fellow traveller, Enter the forest at your own precaution... You have {Player.Health.CurrentHealth} health bars.");
            Play();

            if (!Player.IsAlive())
            {
                GameOver();
            }
        }

        public void ChestRoom(int choice)
        {
            // Simulating chest opening and losing health
            if (choice == 2) // Example: opening the second chest causes health loss
            {
                Player.ReduceHealth(1);
                Console.WriteLine($"You lose 1 health. You have {Player.Health.CurrentHealth} health remaining.");
            }

            // Check if the player is dead after opening the chest
            if (!Player.IsAlive())
            {
                GameOver(); // Ensure no further actions are performed
                return; // Exit to avoid further logic
            }
        }

        public void GameOver()
        {
            Console.WriteLine("GAME OVER! You have lost all your health.");
            Console.WriteLine("Closing the game in 10 seconds...");

            // Sleep for 10 seconds before closing
            System.Threading.Thread.Sleep(10000);

            // Close the application (for console app)
            Environment.Exit(0);
        }

        public abstract void Play();

        public void EndGame()
        {
            Console.WriteLine("You Successfully Survived the forest. Thanks for playing!");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0); // End the game
        }

        
    }
}