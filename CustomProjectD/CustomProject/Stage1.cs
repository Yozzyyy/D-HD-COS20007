using CustomProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Stage1 : Game
    {
        public Stage1(Player player) : base(player) { }

        public override void Play()
        {            Console.WriteLine("There are a total of 4 stages. Play safe and reach the end. You are at Stage 1: Entrance of a spooky forest.\nThere are 3 chests here; be wise with what you pick.");
            Console.WriteLine("*******************************************************************************\r\n          |                   |                  |                     |\r\n _________|________________.=\"\"_;=.______________|_____________________|_______\r\n|                   |  ,-\"_,=\"\"     `\"=.|                  |\r\n|___________________|__\"=._o`\"-._        `\"=.______________|___________________\r\n          |                `\"=._o`\"=._      _`\"=._                     |\r\n _________|_____________________:=._o \"=._.\"_.-=\"'\"=.__________________|_______\r\n|                   |    __.--\" , ; `\"=._o.\" ,-\"\"\"-._ \".   |\r\n|___________________|_._\"  ,. .` ` `` ,  `\"-._\"-._   \". '__|___________________\r\n          |           |o`\"=._` , \"` `; .\". ,  \"-._\"-._; ;              |\r\n _________|___________| ;`-.o`\"=._; .\" ` '`.\"\\` . \"-._ /_______________|_______\r\n|                   | |o;    `\"-.o`\"=._``  '` \" ,__.--o;   |\r\n|___________________|_| ;     (#) `-.o `\"=.`_.--\"_o.-; ;___|___________________\r\n____/______/______/___|o;._    \"      `\".o|o_.--\"    ;o;____/______/______/____\r\n/______/______/______/_\"=._o--._        ; | ;        ; ;/______/______/______/_\r\n____/______/______/______/__\"=._o--._   ;o|o;     _._;o;____/______/______/____\r\n/______/______/______/______/____\"=._o._; | ;_.--\"o.--\"_/______/______/______/_\r\n____/______/______/______/______/_____\"=.o|o_.--\"\"___/______/______/______/____\r\n/______/______/______/______/______/______/______/______/______/______/[BRYANYAP]\r\n*******************************************************************************");

            // Create the chests list for the current stage
            var chestManager1 = new ChestManager(new List<Chest>
            {
                new LootChest("Rusty Chest", new HPMap()),
                new TrapChest("Chest covered in Thorny Vines"),
                new LootChest("Gloomy Chest", new HealingLeaf()),


            });
            

            // Display all chests in the room
            DisplayChests(chestManager1);

            string input;
            bool stage1Complete = false;

            while (!stage1Complete && Player.IsAlive())
            {
                Console.WriteLine("\n- Which chest do you wish to open? (1-3)");
                Console.WriteLine("- Type 'proceed' to move on to the next stage.");
                Console.WriteLine("- Type 'look' to view your inventory:");
                input = Console.ReadLine().ToLower();

                if (input == "proceed")
                {
                    Console.WriteLine("To proceed, solve this riddle: What has keys but can't open locks?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "piano")
                    {
                        Console.WriteLine("The answer is correct! You may proceed onwards.");
                        stage1Complete = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong answer! You will be stuck here if you don't answer correctly.");
                    }
                }
                else if (input == "look")
                {
                    Player.ShowInventory(); // Display inventory contents

                    Console.WriteLine("Would you like to use an item? (yes/no):");
                    string itemInput = Console.ReadLine().ToLower();

                    if (itemInput == "yes")
                    {
                        Console.WriteLine("Enter the number of the item you wish to use:");
                        string itemNumberInput = Console.ReadLine();

                        if (int.TryParse(itemNumberInput, out int itemNumber))
                        {
                            if (itemNumber >= 1 && itemNumber <= Player.Inventory.Count)
                            {
                                // Call UseItem correctly with zero-based index
                                Player.Inventory.UseItem(itemNumber, Player);
                            }
                            else
                            {
                                Console.WriteLine("Invalid item selection. Please enter a valid item number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You chose not to use any item.");
                    }
                }
                else if (int.TryParse(input, out int chestNumber) && chestNumber >= 1 && chestNumber <= chestManager1.Chests.Count)
                {
                    var selectedChest = chestManager1.GetChest(chestNumber - 1);
                    selectedChest.Open(Player); // Open the chest

                    // If the chest contains an item, automatically add it to the player's inventory
                    if (selectedChest.Item != null)
                    {
                        Console.WriteLine($"You found a {selectedChest.Item.Name}. It has been added to your inventory.");
                        Player.Inventory.AddItem(selectedChest.Item); // Automatically add the item to inventory
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 3, type 'proceed' to move on, or 'look' to view your inventory.");
                }
            }

            if (Player.IsAlive())
            {
                Console.WriteLine("You survived Stage 1! Moving to Stage 2...");
                var stage2 = new Stage2(Player); // Stage2 with Player as constructor argument
                stage2.Start(); // Start Stage 2
            }
            else
            {
                EndGame();
            }
        }

        // Method to display all chests in a room
        private void DisplayChests(ChestManager chestManager)
        {
            Console.WriteLine("Chests in this room:");
            for (int i = 0; i < chestManager.Chests.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {chestManager.Chests[i].Name}");
            }
        }
    }
}
