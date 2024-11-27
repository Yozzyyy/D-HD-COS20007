using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomProject
{
    public class Room
    {
        public string Name { get; set; }
        public List<Chest> Chests { get; set; } //creates a list of room and what is store
        public string Riddle { get; set; }
        public string RiddleAnswer { get; set; }

        public Room(string name, List<Chest> chests, string riddle, string RiddleAnswer)
        {
            Name = name;
            Chests = chests;
            Riddle = riddle;
            RiddleAnswer = RiddleAnswer;
        }

    }
}

