using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomProject
{
    public class Room
    {
        public string Name { get; set; }
        public List<Chest> Chests { get; set; }
        public string Riddle { get; set; }
        public string RiddleAnswer { get; set; }

        public Room(string name, List<Chest> chests, string riddle, string RiddleAnswer)
        {
            Name = name;
            Chests = chests;
            Riddle = riddle;
            RiddleAnswer = RiddleAnswer;
        }

        public void Explore(Player player)
        {
            Console.WriteLine($"You are now in the {Name}. Here are the chests in this room:");

            for (int i = 0; i < Chests.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Chests[i].Name}");
            }

            string input;
            do
            {
                Console.Write("Which chest do you want to open? (Enter number) or type 'look' to view your inventory: ");
                input = Console.ReadLine();

                if (input == "look")
                {
                    player.ShowInventory();
                }
                else if (int.TryParse(input, out int chestNumber) && chestNumber >= 1 && chestNumber <= Chests.Count)
                {
                    Chests[chestNumber - 1].Open(player);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            while (input != "proceed" && player.IsAlive());

            if (input == "proceed")
            {
                Console.WriteLine("You chose to proceed.");
            }
        }
        public void InteractWithChest(int chestIndex, Player player)
        {
            Chest chest = Chests[chestIndex - 1];
            chest.Open(player);

            // If the chest contains an item, add it to the player's inventory
            if (chest is LootChest lootChest)
            {
                player.Inventory.AddItem(lootChest.Item);
            }
        }
    }
}

