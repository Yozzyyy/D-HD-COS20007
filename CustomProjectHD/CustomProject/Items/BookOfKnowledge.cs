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
            Console.WriteLine("You used the Book of Knowledge. It temporarily boosts your intelligence. For the Final secret chest the answer is (An Egg)");
            Console.WriteLine("      __...--~~~~~-._   _.-~~~~~--...__\r\n    //               `V'               \\\\ \r\n   //                 |                 \\\\ \r\n  //__...--~~~~~~-._  |  _.-~~~~~~--...__\\\\ \r\n //__.....----~~~~._\\ | /_.~~~~----.....__\\\\\r\n====================\\\\|//====================\r\n                dwb `---`");
            // Here, you can apply special buffs or effects
        }
    }
}
