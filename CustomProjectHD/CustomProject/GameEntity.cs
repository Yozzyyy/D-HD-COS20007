using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public abstract class GameEntity
    {
        public string Name { get; protected set; }
        public abstract void Interact(Player player);
    }
}
