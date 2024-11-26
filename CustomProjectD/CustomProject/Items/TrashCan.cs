using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class TrashCan : Item
    {
        public TrashCan() : base("A Trashcan", "It smells. Ew.") { }

        public override void Use(Player player)
        {
            Console.WriteLine("You used the Trashcan. It does nothing. LOL.");
            // Here, you can apply special buffs or effects
        }
    }
}
