using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Items
{
    public class Key2 : Item
    {
        public Key2() : base("A Lost Key", "A key? What does it do? .") { }

        public override void Use(Player player)
        {
            Console.WriteLine("You found the second key. but do you have the first? walk the path and you shall claim what's yours.");
            Console.WriteLine("                                                        ██████          \r\n                                                    ████░░░░░░████      \r\n                                                  ██░░░░░░░░░░    ██    \r\n                                                ██░░░░██████████░░  ██  \r\n                                                ██░░░░██      ██░░  ██  \r\n████████████████████████████████████████████████░░░░██          ██░░░░██\r\n██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██          ██░░░░██\r\n  ██░░░░██░░░░██░░░░████████████████████████████░░░░██          ██░░░░██\r\n    ████  ████  ████                            ██░░░░██      ██░░░░██  \r\n                                                ██░░░░██████████░░░░██  \r\n                                                  ██░░░░░░░░░░░░░░██    \r\n                                                    ████░░░░░░████      \r\n                                                        ██████          \r\n");
        }
    }
}
