using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public abstract class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public abstract void Use(Player player); // Method to use the item

        // Corrected method to accept ChestManager instance and Item
        public void AddLootChest(ChestManager chestManager, string name)
        {
            // Add a LootChest instance to the ChestManager's Chests list
            chestManager.Chests.Add(new LootChest(name, this)); // 'this' refers to the Item instance
        }
    }
}
