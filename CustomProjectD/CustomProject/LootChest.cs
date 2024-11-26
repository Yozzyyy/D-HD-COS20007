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

        public LootChest(string name, Item item) : base(name,item)
        {
            Item = item;
        }

        protected override void OnOpen(Player player)
        {
            Console.WriteLine($"You opened the {Name} and found a {Item.Name}!");
            player.AddToInventory(Item);
        }
    }
}
