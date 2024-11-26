using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Items
{
    public class TreeBottle : Item
    {
        public TreeBottle() : base("A bottle", "slimy like substance.") { }

        public override void Use(Player player)
        {
            Console.WriteLine("It contain a wwird slimy like texture of substance? what is it? will i die?");
            Console.WriteLine("                                                                  \r\n                                                                  \r\n                            ░░                                    \r\n                            ░░        ░░                          \r\n                                  ░░  ░░                          \r\n                            ░░░░  ░░░░                            \r\n                          ▒▒░░▒▒▒▒▒▒▒▒                            \r\n                            ▒▒░░░░▒▒    ░░░░                      \r\n                        ░░  ▒▒  ▒▒▒▒                              \r\n                    ░░      ▒▒░░▒▒▒▒                              \r\n                    ░░      ▒▒░░░░▓▓    ░░                        \r\n                        ░░▓▓░░░░░░░░▓▓░░░░                        \r\n                      ░░▓▓░░░░░░░░  ░░▓▓░░                        \r\n                      ██░░░░░░░░░░░░░░░░██                        \r\n                      ▒▒░░░░░░░░░░░░░░░░▒▒░░                      \r\n                      ░░▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒░░                      \r\n                      ▓▓▒▒▒▒▒▒▒▒▒▒░░▒▒▓▓▓▓                        \r\n                      ▒▒░░▓▓▒▒▒▒▒▒▒▒▓▓░░▒▒                        \r\n                        ▒▒▓▓░░░░░░░░▓▓▒▒                          \r\n                            ░░    ░░                              \r\n                                                                  \r\n                                                                  ");
            player.RestoreHealth(1); // Adds 1 to health
        }
    }
}
