
using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            // Welcome message and player setup
            Console.WriteLine("Welcome to the Forest Horror Game!, I'm a traveller like you but from 25 years ago... follow along as In read the rules and how to play the game:\n");
            Console.WriteLine("1.There is no turning back after selecting the room of choice be wise and careful with what you pick...\n ");
            Console.WriteLine("2.Becareful with what chest you open some may lead you to your downfall...\n ");
            Console.WriteLine("3.There will be riddles at the end of each room solve it and complete the game or else be stuck here forever and ever...\n ");
            Console.WriteLine("4.Item are usable, Don't think lighty of it...\n ");
            Console.WriteLine("That's all for rules. Remember traveller never LOOK BACK AS YOU MAY LOST YOUR WAY...\n\n ");


            Console.WriteLine("How may I adress you? traveller: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("");

            // Create a new player
            Player player = new Player(playerName);

            // Create a new game and start it
            Game game = new Stage1(player);
            game.Start();

            
        }
    }
}