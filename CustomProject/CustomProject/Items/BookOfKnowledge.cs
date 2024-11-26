using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class BookOfKnowledge : Item
    {
        public BookOfKnowledge() : base("Book of Knowledge", "A book that contains ancient wisdom.") { }

        public override void Use(Player player)
        {
            Console.WriteLine("You used the Book of Knowledge. It temporarily boosts your intelligence.");
            // Here, you can apply special buffs or effects
        }
    }
}
