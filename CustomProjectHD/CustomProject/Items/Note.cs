using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Items
{
    public class Note : Item
    {
        public Note() : base("A Note", "A Note Containing a message") { }

        public override void Use(Player player)
        {
            Console.WriteLine("Becareful of the forest.. NEVER Never open the second chest that is not save remember never open second chest");
            Console.WriteLine("            ____________\r\n           /     _.'\\   \\\r\n          /   _.'    \\   \\\r\n         /_.-'        \\___\\\r\n        |\\_\\ ``   .-   \\ _/|\r\n        |  _\\___________.  | P\r\n        | /              \\ | r\r\n        |/                \\| 5\r\n        |__________________| 9\r\n");
        }
    }
}
