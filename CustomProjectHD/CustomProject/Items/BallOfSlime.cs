﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class BallOfSlime : Item
    {
        public BallOfSlime() : base("A Ball of Slime", "a sticky ball of slime") { }

        public override void Use(Player player)
        {
            Console.WriteLine("It's a ball? It's a green marble? wait no it's a ball of slime?? ");
            Console.WriteLine("                ██████████                \r\n        ████████░░░░░░░░░░████████        \r\n      ██░░░░░░░░░░░░░░░░░░░░░░░░░░██      \r\n    ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██    \r\n  ██░░░░░░░░░░░░░░░░░░            ░░██    \r\n  ██░░░░░░░░░░░░░░                  ░░██  \r\n██░░░░░░░░░░                        ░░░░██\r\n██░░░░░░░░░░                        ░░░░██\r\n██░░░░░░░░░░        ██        ██      ░░██\r\n██░░░░░░░░          ██        ██      ░░██\r\n██░░░░░░░░          ██        ██      ░░██\r\n██░░░░░░░░                            ░░██\r\n██░░░░░░░░░░                          ░░██\r\n██░░░░░░░░░░░░                        ░░██\r\n██░░░░░░░░░░░░░░                      ░░██\r\n██░░░░░░░░░░░░░░░░░░                ░░░░██\r\n████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████\r\n    ██████████████████████████████████    ");
            Console.WriteLine("Im a wise slime to give some warning... always count to two to not face the consequences.");
        }
    }
}