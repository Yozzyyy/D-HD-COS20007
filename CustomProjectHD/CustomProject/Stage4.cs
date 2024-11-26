using CustomProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Stage4 : Game
    {
        private Room finalRoom; // Declare finalRoom as a class-level field

        public Stage4(Player player) : base(player) { }

        public override void Play()
        {
            Console.WriteLine("You are in the Final Stage Room. There is only 1 room here.");

            // Initialize finalRoom here
            finalRoom = new Room("My House", new List<Chest>
        {
            new LootChest("Locked Chest", new BallOfSlime()), // will be used for a locked chest
            new LootChest("Secret Chest", new SecretChest(), "What has to be broken before you can use it?", "An egg") // Riddle-locked chest
        }, "", "");

            Console.WriteLine("This is your final challenge. You have reached the Final Room!");

            bool stageComplete = false;

            while (!stageComplete && Player.IsAlive())
            {
                Console.WriteLine("\nAvailable actions:");
                Console.WriteLine("- Enter '1' to open the Final Chest.");
                Console.WriteLine("- Enter '2' to open a secret Final Chest");
                Console.WriteLine("- Type 'look' to check your inventory.");

                string input = Console.ReadLine().ToLower();

                if (input == "1")
                {
                    // Open the final chest
                    finalRoom.Chests[0].Open(Player);

                    // After opening the chest, end the game with the biggest reward
                    Console.WriteLine("Congratulations! For Completing the Game Please Play again so find whats our secret reward");
                    stageComplete = true;
                }
                else if (input == "2")
                {
                    Chest secretChest = finalRoom.Chests[1];
                    if (secretChest is LootChest lootChest && lootChest.IsLocked)
                    {
                        Console.WriteLine("This chest is locked with a riddle: What has to be broken before you can use it?");
                        bool correctAnswer = false;

                        while (!correctAnswer)
                        {
                            Console.WriteLine("Please enter your answer:");
                            string riddleAnswer = Console.ReadLine().Trim();

                            if (lootChest.Unlock(riddleAnswer)) // Assuming Unlock method checks the answer
                            {
                                correctAnswer = true;
                                Console.WriteLine("OOhh, you managed to find the secret ending? Congrats for finding the answers!");
                                Console.WriteLine("             ___________\r\n            '._==_==_=_.'\r\n            .-\\:      /-.\r\n           | (|:.     |) |\r\n            '-|:.     |-'\r\n              \\::.    /\r\n               '::. .'\r\n                 ) (\r\n               _.' '._\r\n          Bry `\"\"\"\"\"\"\"`\r\n");
                                stageComplete = true;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect answer. The chest remains locked.");
                            }
                        }
                    }
                }
                else if (input == "look")
                {
                    Console.WriteLine("\nYour Inventory:");
                    Player.ShowInventory();

                    Console.WriteLine("Would you like to use an item? (yes/no):");
                    string useItemInput = Console.ReadLine().ToLower();

                    if (useItemInput == "yes")
                    {
                        Console.WriteLine("Enter the name of the item you wish to use:");
                        string itemName = Console.ReadLine();
                        Player.UseItem(itemName); // Pass the item name
                    }
                    else
                    {
                        Console.WriteLine("You chose not to use an item.");
                    }
                }

                // End the game after completing the stage
                if (stageComplete)
                {
                    EndGame();
                }
            }
        }

        
    }
}

