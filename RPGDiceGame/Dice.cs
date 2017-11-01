using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDiceGame
{
    public class Dice
    {
        private int numOfSides { get; set; }
        public Dice(int numOfSides)
        {
            this.numOfSides = numOfSides;

        }
        public int RollDice()
        {
            Random rand = new Random();
            return rand.Next(1, numOfSides + 1);
        }
    }
}
