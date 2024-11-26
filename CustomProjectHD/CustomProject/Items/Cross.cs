using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Items
{
    public class Cross : Item
    {
        public Cross() : base("A Cross", "A Religous Practice of Christianity.") { }

        public override void Use(Player player)
        {
            Console.WriteLine("A blessing of and divine protection from the one above all, 20 years ago, this church was half burned by a fire, but now it's protected by divine protection");
            Console.WriteLine("                    .-=====-.\r\n                    | .\"\"\". |\r\n                    | |   | |\r\n                    | |   | |\r\n                    | '---' |\r\n                    |       |\r\n                    |       |\r\n .-================-'       '-================-.\r\nj|  _                                          |\r\ng|.'o\\                                    __   |\r\ns| '-.'.                                .'o.`  |\r\n '-==='.'.=========-.       .-========.'.-'===-'\r\n        '.`'._    .===,     |     _.-' /\r\n          '._ '-./  ,//\\   _| _.-'  _.'\r\n             '-.| ,//'  \\-'  `   .-'\r\n                `//'_`--;    ;.-'\r\n                  `\\._ ;|    |\r\n                     \\`-'  . |\r\n                     |_.-'-._|\r\n                     \\  _'_  /\r\n                     |; -:- | \r\n                     || -.- \\ \r\n                     |;     .\\\r\n                     / `'\\'`\\-;\r\n                    ;`   '. `_/\r\n                    |,`-._;  .;\r\n                    `;\\  `.-'-;\r\n                     | \\   \\  |\r\n                     |  `\\  \\ |\r\n                     |   )  | |\r\n                     |  /  /` /\r\n                     | |  /|  |\r\n                     | | / | /\r\n                     | / |/ /|\r\n                     | \\ / / |\r\n                     |  /o | |\r\n                     |  |_/  |\r\n                     |       |\r\n                     |       |\r\n                     |       |\r\n                     |       |\r\n                     |       |\r\n                     |       |\r\n                     |       |\r\n                     '-=====-'");

        }
    }
}