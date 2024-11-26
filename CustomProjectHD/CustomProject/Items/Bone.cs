using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Items
{
    public class Bone : Item
    {
        public Bone() : base("Bone", "A dog bone") { }

        public override void Use(Player player)
        {
            Console.WriteLine("The original dog ate this but sadly passed away and was the bone was never thrown away, WAIT why is there to be appear a craved out map to this room on the bone?");
            Console.WriteLine("    ████████                                                                    ████████    \r\n  ██        ██                                                                ██        ██  \r\n██            ██                                                            ██            ██\r\n██              ██                                                        ██              ██\r\n██              ██                                                        ██              ██\r\n██                ████████████████████████████████████████████████████████                ██\r\n  ██                                                                                    ██  \r\n    ██                                                                                ██    \r\n    ██                                                                                ██    \r\n    ██                                                                                ██    \r\n  ██                                                                                    ██  \r\n██                ████████████████████████████████████████████████████████                ██\r\n██              ██                                                        ██              ██\r\n██              ██                                                        ██              ██\r\n██            ██                                                            ██            ██\r\n  ██        ██                                                                ██        ██  \r\n    ████████                                                                    ████████    \r\n");
        }
    }
}
