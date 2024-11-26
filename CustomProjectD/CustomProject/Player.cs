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
        private List<Item> _inventory = new List<Item>(); // Store items in inventory
        public Health Health { get; private set; }
        public Inventory Inventory { get; set; }

        // Constructor accepting a name and initializing health
        public Player(string name)
        {
            Name = name;
            Health = new Health(3); // Player starts with 3 health
            Inventory = new Inventory(); // Initialize inventory
        }

        public void AddToInventory(Item item)
        {
            _inventory.Add(item);
            Console.WriteLine($"You found a {item.Name} and added it to your inventory.");
        }

        public void ShowInventory()
        {
            Console.WriteLine("Your inventory:");
            if (_inventory.Count > 0)
            {
                for (int i = 0; i < _inventory.Count; i++)
                {
                    var item = _inventory[i];
                    Console.WriteLine($"{i + 1}. {item.Name} - {item.Description}");
                }
            }
            else
            {
                Console.WriteLine("Your inventory is empty.");
            }
        }

        public void UseItem(int itemIndex)
        {
            var item = Inventory.GetItem(itemIndex - 1); // Get the item from inventory
            if (item != null)
            {
                item.Use(this); // Use the item
                Console.WriteLine($"You used the {item.Name}.");
            }
            else
            {
                Console.WriteLine("Invalid item selection.");
            }
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
