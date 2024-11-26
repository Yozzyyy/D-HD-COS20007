using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomProject
{
    public class Player
    {
        public string Name { get; private set; }
        public Health Health { get; private set; }
        public Inventory Inventory { get; set; } // Use the Inventory class for managing items

        // Constructor accepting a name and initializing health
        public Player(string name)
        {
            Name = name;
            Health = new Health(3); // Player starts with 3 health
            Inventory = new Inventory(); // Initialize inventory
        }

        // Use Inventory's AddItem method to add items
        public void AddToInventory(Item item)
        {
            Inventory.AddItem(item); // Correctly add item to the player's inventory using Inventory's method
        }

        // Show items in the inventory
        public void ShowInventory()
        {
            Inventory.ShowInventory(); // Use Inventory's ShowInventory method
        }

        // Use an item from the inventory
        public void UseItem(string itemName)
        {
            Inventory.UseItem(itemName, this); // Use Inventory's UseItem method to consume the item
        }
        

        public void RestoreHealth(int amount)
        {
            Health += amount;
            Console.WriteLine($"Your health is now {Health.CurrentHealth}.");
        }

        public bool IsAlive()
        {
            return Health.IsAlive();
        }

        public void ReduceHealth(int amount)
        {
            Health.DecreaseHealth(amount);
            Console.WriteLine($"You have {Health.CurrentHealth} health remaining.");
        }
    }
}
