using System;
using System.Collections.Generic;
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

        // Method to decrease health
        public void DecreaseHealth(int amount)
        {
            CurrentHealth -= amount;
            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }
        public static Health operator +(Health health, int amount)
        {
            health.CurrentHealth += amount;
            return health;
        }

        // Method to check if player is alive
        public bool IsAlive()
        {
            return CurrentHealth > 0;
        }

        // Method to heal the player (if needed)
        public void Heal(int amount)
        {
            CurrentHealth += amount;
            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
        }

        // Method to reset health (optional for stages or resets)
        public void ResetHealth()
        {
            CurrentHealth = MaxHealth;
        }
    }
}
