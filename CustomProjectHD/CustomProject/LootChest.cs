using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomProject
{
    public class LootChest : Chest
    {
        public Item Item { get; set; }
        private string Riddle { get; }
        private string Answer { get; }
        public bool IsLocked { get; set; } // Tracks if the chest is locked

        // Add optional riddle and answer parameters
        public LootChest(string name, Item item, string riddle = null, string answer = null)
            : base(name, item)
        {
            Item = item;
            Riddle = riddle;
            Answer = answer;
            IsLocked = !string.IsNullOrEmpty(Riddle) && !string.IsNullOrEmpty(Answer); // Lock if there's a riddle
        }

        protected override void OnOpen(Player player)
        {
            if (IsLocked)
            {
                Console.WriteLine($"This chest is locked with a riddle: {Riddle}");
                Console.WriteLine("Please enter your answer:");

                string playerAnswer = Console.ReadLine();

                if (Unlock(playerAnswer))
                {
                    Console.WriteLine("You answered correctly! The chest is now open.");
                    Console.WriteLine($"You found a {Item.Name}!");
                    player.AddToInventory(Item);
                }
                else
                {
                    Console.WriteLine("Incorrect answer. The chest remains locked.");
                }
            }
            else
            {
                Console.WriteLine($"You opened the {Name} and found a {Item.Name}!");
                player.AddToInventory(Item);
            }
        }

        public bool Unlock(string answer)
        {
            if (IsLocked && answer.Equals(Answer, StringComparison.OrdinalIgnoreCase))
            {
                IsLocked = false; // Unlock the chest
                return true;
            }
            return false; // Answer was incorrect
        }
    }
}

