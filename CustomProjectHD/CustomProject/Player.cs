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
        public string Name { get; private set; } // the player name
        public Health Health { get; private set; } //use the health class for the player
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
            Inventory.AddItem(item); //item collected from chest will be added to Inventory
        }

        // Show items in the inventory
        public void ShowInventory()
        {
            Inventory.ShowInventory(); //when use the "look" it will show the inventory
        }

        // Use an item from the inventory
        public void UseItem(string itemName)
        {
            Inventory.UseItem(itemName, this); //use the item when called by it's name
        }
        

        public void RestoreHealth(int amount) //some items that have a healing buff will 
        {
            Health += amount;
            Console.WriteLine($"Your health is now {Health.CurrentHealth}.");
        }

        public bool IsAlive() //from health
        {
            return Health.IsAlive(); //check if player is alive or not
        }

        public void ReduceHealth(int amount) //reduce health for the chest
        {
            Health.DecreaseHealth(amount);
            Console.WriteLine($"You have {Health.CurrentHealth} health remaining.");
        }
    }
}
