using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Items
{
    public class Poison : Item
    {
        public Poison() : base("Poison", "A thick consistency of poison") { }

        public override void Use(Player player)
        {
            Console.WriteLine("A poison but does it do? Do i test and you shall know. don't regret any actions taken");
            Console.WriteLine("                                                                                \r\n                                                                                \r\n                                                                                \r\n                                                                                \r\n                                                                                \r\n                              ▒▒░░▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒                              \r\n                              ▒▒              ░░▒▒                              \r\n                              ▒▒                ▒▒                              \r\n                              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                              \r\n                              ░░▒▒░░░░░░░░░░░░▒▒░░                              \r\n                                ▒▒            ▒▒                                \r\n                                ▒▒            ▒▒                                \r\n                                ▒▒            ▒▒                                \r\n                                ▒▒            ▒▒                                \r\n                                ▒▒            ▒▒                                \r\n                                ▒▒            ▒▒                                \r\n                              ▒▒▒▒            ▒▒▒▒                              \r\n                            ▒▒                    ▒▒                            \r\n                          ▒▒                        ▒▒                          \r\n                        ▒▒        ░░                  ▒▒                        \r\n                      ▒▒  ████▓▓██▓▓██▓▓▓▓▓▓██    ▓▓▓▓  ▒▒                      \r\n                    ▒▒  ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ▒▒                    \r\n                    ▒▒  ▓▓▓▓▓▓▓▓  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ▓▓▓▓▓▓  ▒▒                    \r\n                  ▒▒  ▓▓▓▓▓▓▓▓  ░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓    ▓▓▓▓▓▓  ▒▒░░                \r\n                  ▒▒  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ░░  ░░  ▓▓▒▒▒▒▓▓▓▓▓▓  ▒▒                  \r\n                  ▒▒  ▓▓▓▓▓▓▓▓▓▓▓▓              ▓▓▓▓▓▓▓▓▓▓  ▒▒░░                \r\n                  ▒▒  ▓▓▓▓▓▓▓▓▓▓▓▓  ████  ████  ▓▓▓▓▓▓▓▓▓▓  ▒▒                  \r\n                  ▒▒  ▓▓▓▓▓▓▓▓▓▓▓▓  ██      ██  ▓▓▓▓▓▓▓▓▓▓  ▒▒░░                \r\n                  ▒▒  ▓▓▓▓▓▓▓▓▓▓▓▓          ▓▓  ▓▓▓▓▓▓▓▓██  ▒▒                  \r\n                  ▒▒  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓          ▓▓▓▓▓▓▓▓▓▓▓▓  ▒▒░░                \r\n                  ▒▒  ▓▓▓▓▓▓▓▓    ██  ██  ▓▓  ▓▓    ██▓▓▓▓  ▒▒                  \r\n                    ▒▒  ▓▓▓▓▓▓▓▓  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ▓▓▓▓▓▓░░▒▒                    \r\n                    ▒▒░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ▒▒                    \r\n                      ▒▒  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ▒▒                      \r\n                      ▒▒                                ▒▒                      \r\n                        ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                        \r\n                        ▒▒  ░░░░░░░░░░░░░░░░  ░░░░    ▒▒                        \r\n                        ▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒                        \r\n                                                                                \r\n                                                                                \r\n");
            player.Health.DecreaseHealth(1); // Decrease the player's health by 1
            Console.WriteLine("You lost 1 health from the poison.");
        }
    }
}

