using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDiceGame
{
    public class Player
    {
        private int TotalHealth;
        private string PlayerName;
        public bool isAlive;
        public int currentHealth;
        public Player(string playerName)
        {
            this.TotalHealth = SetHealth();
            this.PlayerName = playerName;
            this.isAlive = true;
            this.currentHealth = this.TotalHealth;
        }

        public int SetHealth()
        {
            int health = new Dice(20).RollDice();
            int multiplier = new Dice(4).RollDice();

            return health * multiplier;
        }
        public void DisplayHealth(bool clear = false)
        {
            if(clear)
                Console.Clear();
            Console.WriteLine(string.Format("Your current Health is: {0}", currentHealth));
        }

        public bool IsAlive()
        {
            if (currentHealth <= 0)
            {
                return this.isAlive = false;
            }
            else
            {
                return this.isAlive = true;
            }
        }

    }
}
