using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Stage4 : Game
    {
        public Stage4(Player player) : base(player) { }

        public override void Play()
        {
            Console.WriteLine("You are in the Final Stage Room. There is only 1 room here.");

            // Define the final room with one chest
            var finalRoom = new Room("My House", new List<Chest>
            {
                new LootChest("Shiny Rainbow Chest", new Placeholder())
            }, "", "");  // No riddle needed

            Console.WriteLine("This is your final challenge. You have reached the Final Room!");

            bool stageComplete = false;

            while (!stageComplete && Player.IsAlive())
            {
                Console.WriteLine("\nAvailable actions:");
                Console.WriteLine("- Enter '1' to open the Final Chest.");
                Console.WriteLine("- Type 'look' to check your inventory.");
                Console.WriteLine("- Type 'use' to use an item from your inventory.");

                string input = Console.ReadLine().ToLower();

                if (input == "1")
                {
                    // Open the final chest
                    finalRoom.Chests[0].Open(Player);

                    // After opening the chest, end the game with the biggest reward
                    Console.WriteLine("Congratulations! You've received the Biggest DICK Ever!");
                    stageComplete = true;
                }
                else if (input == "look")
                {
                    // Display inventory
                    Console.WriteLine("\nYour Inventory:");
                    Player.ShowInventory();

                    Console.WriteLine("Would you like to use an item? (yes/no):");
                    string useItemInput = Console.ReadLine().ToLower();

                    if (useItemInput == "yes")
                    {
                        Console.WriteLine("Enter the number of the item you wish to use:");
                        if (int.TryParse(Console.ReadLine(), out int itemIndex) && itemIndex >= 1 && itemIndex <= Player.Inventory.Count)
                        {
                            Player.Inventory.UseItem(itemIndex - 1, Player); // Use the selected item
                        }
                        else
                        {
                            Console.WriteLine("Invalid item selection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You chose not to use an item.");
                    }
                }
                else if (input == "use")
                {
                    // Directly use an item from the inventory
                    if (Player.Inventory.Count > 0)
                    {
                        Console.WriteLine("Enter the number of the item you wish to use:");
                        if (int.TryParse(Console.ReadLine(), out int itemIndex) && itemIndex >= 1 && itemIndex <= Player.Inventory.Count)
                        {
                            Player.Inventory.UseItem(itemIndex - 1, Player); // Use the selected item
                        }
                        else
                        {
                            Console.WriteLine("Invalid item selection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your inventory is empty.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please try again.");
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
