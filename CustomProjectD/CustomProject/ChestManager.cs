using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class ChestManager
    {
        public List<Chest> Chests { get; set; }

        public ChestManager(List<Chest> chests)
        {
            Chests = chests; // Initialize the list of chests
        }

        // Corrected method to accept an Item instance instead of a string
        public void AddLootChest(string name, Item item)
        {
            Chests.Add(new LootChest(name, item)); // Use Item instance
        }

        public void AddTrapChest(string name)
        {
            Chests.Add(new TrapChest(name));
        }

        public Chest GetChest(int index)
        {
            if (index >= 0 && index < Chests.Count)
            {
                return Chests[index];
            }
            return null;
        }
    }

}
