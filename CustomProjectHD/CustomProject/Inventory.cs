using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Inventory
    {
        private List<Item> _items = new List<Item>();
        public int Count => _items.Count;

        public void AddItem(Item item)
        {
            _items.Add(item);
            Console.WriteLine($"You have found a {item.Name} and added it to your inventory.");
        }



        public void ShowInventory()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("Your inventory is empty.");
                return;
            }

            Console.WriteLine("Your inventory contains:");
            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_items[i].Name} - {_items[i].Description}");
            }
        }

        public void UseItem(string itemName, Player player)
        {
            var item = GetItemByName(itemName);

            if (item == null)
            {
                Console.WriteLine($"Item '{itemName}' not found in your inventory.");
                return;
            }

            Console.WriteLine($"Using {item.Name}...");
            item.Use(player); // Assuming that item.Use will do something with the player
            _items.Remove(item); // Remove the item after use
        }

        public bool HasItem(string itemName)
        {
            return _items.Any(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
        }

        // Example of a method to retrieve an item by name
        public Item GetItemByName(string itemName)
        {
            return _items.FirstOrDefault(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
