using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Items
{
    public class Pendent : Item
    {
        public Pendent() : base("A Pendent", "A Heirloom Necklace") { }

        public override void Use(Player player)
        {
            Console.WriteLine("This belongs to a family who used to live here. It seems like they forgot their precious heirloom.");
            Console.WriteLine("              o--o--=g=--o--o     \r\n               /      .'       \\\r\n               o      '.       o\r\n                \\             /\r\n                 o           o\r\n                  \\         /\r\n                   o       o\r\n                    \\     /\r\n                     o   o\r\n                      \\_/\r\n                       =\r\n                      .^.\r\n                     '   '\r\n                     '. .'\r\n                       !    lc\r\n                       ");
        }
    }
}
