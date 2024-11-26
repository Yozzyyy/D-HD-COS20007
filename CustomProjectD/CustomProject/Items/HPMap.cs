using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Items
{
    public class HPMap : Item
    {
        public HPMap() : base("A Map", "It might tell something useful") { }

        public override void Use(Player player)
        {
            Console.WriteLine("There is a healing item around stage 2 room number 3 find it and that item is yours to keep let the wind guide you... ");
            // Here, you can apply special buffs or effects
        }
    }
}
