using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Placeholder : Item
    {
        public Placeholder() : base("A Placeholder", "Null value") { }

        public override void Use(Player player)
        {
            Console.WriteLine("palceholder items.");
            // Here, you can apply special buffs or effects
        }
    }
}