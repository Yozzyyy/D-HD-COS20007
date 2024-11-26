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

        public void UseItem(int itemIndex, Player player)
        {
            int zeroBasedIndex = itemIndex - 1;

            if (zeroBasedIndex < 0 || zeroBasedIndex >= _items.Count)
            {
                Console.WriteLine("Invalid item selection.");
                return;
            }

            // Get the item from the inventory
            var item = _items[zeroBasedIndex];
            Console.WriteLine($"Using {item.Name}...");

            // Call the Use method of the item and pass the player
            item.Use(player);

            // Optionally remove the item after use
            _items.RemoveAt(zeroBasedIndex);
        }
        public Item GetItem(int index)
        {
            if (index >= 0 && index < _items.Count)
            {
                return _items[index];
            }
            return null;  // Return null if the index is out of bounds
        }
    }
}
