using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomProject
{
    public class TrapChest : Chest
    {
        public TrapChest(string name) : base(name, null)
        {

        }


        protected override void OnOpen(Player player)
        {
            Console.WriteLine($"A spider jumped on {Name} face it was a trap! You lose 1 health. Becareful what you open or you shall face the consequences...");
            player.ReduceHealth(1);
        }
    }
}
