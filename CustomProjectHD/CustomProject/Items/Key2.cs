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
            Console.WriteLine("You found the second key.What represents the raging beauty of destruction? Fire is the answer");
            Console.WriteLine("                                                        ██████          \r\n                                                    ████░░░░░░████      \r\n                                                  ██░░░░░░░░░░    ██    \r\n                                                ██░░░░██████████░░  ██  \r\n                                                ██░░░░██      ██░░  ██  \r\n████████████████████████████████████████████████░░░░██          ██░░░░██\r\n██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██          ██░░░░██\r\n  ██░░░░██░░░░██░░░░████████████████████████████░░░░██          ██░░░░██\r\n    ████  ████  ████                            ██░░░░██      ██░░░░██  \r\n                                                ██░░░░██████████░░░░██  \r\n                                                  ██░░░░░░░░░░░░░░██    \r\n                                                    ████░░░░░░████      \r\n                                                        ██████          \r\n");
        }
    }
}
