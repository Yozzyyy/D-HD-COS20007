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
            Console.WriteLine("It just a Trashcan lol, it does nothing. But now you stink from the stench");
            Console.WriteLine(" _.,-----/=\\-----,._\r\n (__ ~~~\"\"\"\"\"\"\"~~~ __)\r\n  | ~~~\"\"\"\"\"\"\"\"\"~~~ |\r\n  | |  ; ,   , ;  | |\r\n  | |  | |   | |  | |\r\n  | |  | |   | |  | |\r\n  | |  | |   | |  | |\r\n  | |  | |   | |  | |\r\n  | |  | |   | |  | |\r\n  | |  | |   | |  | |\r\n  | |  | |   | |  | |\r\n  |. \\_| |   | |_/ .|\r\n   `-,.__ ~~~ __.,-'\r\n         ~~~~~");
            // Here, you can apply special buffs or effects
        }
    }
}
