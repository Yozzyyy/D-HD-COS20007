using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Health
    {
        public int CurrentHealth { get; private set; }
        public int MaxHealth { get; private set; }

        public Health(int maxHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
        }


        public void DecreaseHealth(int amount) //decrease the health then is called in the cursed object methods 
        {
            CurrentHealth -= amount;
            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }
        //static is shared across all
        public static Health operator +(Health health, int amount) //the "+" allows us to call the operator in methods
        {
            health.CurrentHealth += amount; //amount is the "1" then we plus from our current healths
            return health;
        }

       
        public bool IsAlive() //check player is alive
        {
            return CurrentHealth > 0;
        }

        
    }
}
