using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Items
{
    public class SecretChest : Item
    {
        public SecretChest() : base("SecretChest", "A Secret Chest.") { }

        public override void Use(Player player)
        {
            Console.WriteLine("A secret chest that lead to another ending");
        }
    }
}
