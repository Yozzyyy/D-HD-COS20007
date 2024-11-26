using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public abstract class Chest
    {
        public string Name { get; }
        public bool IsOpened { get; private set; } = false; // Tracks if the chest is opened
        public Item Item { get; protected set; } // Item contained in the chest

        public Chest(string name, Item item)
        {
            Name = name;
            Item = item;
        }

        public void Open(Player player)
        {
            if (IsOpened)
            {
                Console.WriteLine($"The {Name} has already been opened.");
                return;
            }

            IsOpened = true;
            OnOpen(player);
        }


        protected abstract void OnOpen(Player player);
    }
}
