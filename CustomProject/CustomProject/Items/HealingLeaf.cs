using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class HealingLeaf:Item
    {
    public HealingLeaf() : base("Healing Leaf", "A mystical leaf that restores 1 health.") { }

    public override void Use(Player player)
    {
        Console.WriteLine("You used the Healing Leaf and restored 1 health.");
        player.RestoreHealth(1); // Adds 1 to health
    }
}
}
