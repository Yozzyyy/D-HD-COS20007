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
            Console.WriteLine("MUMMMMY, what why does that word have so many repeated letter? wait i cant see the letter? maybe that's an indicator? or is it? hmmmmmmm");
            Console.WriteLine("            ____________\r\n           /     _.'\\   \\\r\n          /   _.'    \\   \\\r\n         /_.-'        \\___\\\r\n        |\\_\\ ``   .-   \\ _/|\r\n        |  _\\___________.  | P\r\n        | /              \\ | r\r\n        |/                \\| 5\r\n        |__________________| 9\r\n");
        }
    }
}
