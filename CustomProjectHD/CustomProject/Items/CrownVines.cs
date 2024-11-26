using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Items
{
    public class CrownVine : Item
    {
        public CrownVine() : base("A Crown", "A lost Crown") { }

        public override void Use(Player player)
        {
            Console.WriteLine(".\r\n                  .       |         .    .\r\n            .  *         -*-          *\r\n                 \\        |         /   .\r\n.    .            .      /^\\     .              .    .\r\n   *    |\\   /\\    /\\  / / \\ \\  /\\    /\\   /|    *\r\n .   .  |  \\ \\/ /\\ \\ / /     \\ \\ / /\\ \\/ /  | .     .\r\n         \\ | _ _\\/_ _ \\_\\_ _ /_/_ _\\/_ _ \\_/\r\n           \\  *  *  *   \\ \\/ /  *  *  *  /\r\n            ` ~ ~ ~ ~ ~  ~\\/~ ~ ~ ~ ~ ~ '");
        }
    }
}
